using ClientDatabase.Services;
using System;
using ClientDatabase.Models;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClientDatabase
{
    public partial class Form1 : Form
    {
        private IClientService clientService;
        private IFileService service;
        private int index;
        public Form1()
        {
            InitializeComponent();
            clientService = new ClientService();
            service = new FileService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text)
                && !string.IsNullOrEmpty(txtSurname.Text)
                && !string.IsNullOrEmpty(txtPhoneNumber.Text)
                && !string.IsNullOrEmpty(txtDispatch.Text)
                && !string.IsNullOrEmpty(txtArrival.Text))
            {                
                Human human = new Human()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Dispatch = txtDispatch.Text,
                    Arrival = txtArrival.Text
                };
                clientService.AddClient(human);
                var obj = JsonConvert.SerializeObject(clientService.GetClients());
                service.WriteToFile(obj);
            }
            else
            {
                MessageBox.Show("Неверный ввод");
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            string fileContent = service.ReadFormFile();
            List<Human> listUsers = JsonConvert.DeserializeObject<List<Human>>(fileContent);
            dataGridView1.DataSource = listUsers;
        }
    }
}
