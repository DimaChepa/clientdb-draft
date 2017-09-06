using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDatabase.Models
{
    internal class Human
    {
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }
        [DisplayName("Отправление")]
        public string Dispatch { get; set; }
        [DisplayName("Прибытие")]
        public string Arrival { get; set; }
    }
}
