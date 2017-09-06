using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientDatabase.Models;

namespace ClientDatabase.Services
{
    internal class ClientService : IClientService
    {
        private List<Human> _people;
        public ClientService()
        {
            _people = new List<Human>();
        }
        public void AddClient(Human human)
        {            
            _people.Add(human);
        }

        public void RemoveHuman(int id)
        {
            throw new NotImplementedException();
        }
        public List<Human> GetClients()
        {
            return _people;
        }
    }
}
