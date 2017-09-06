using ClientDatabase.Models;
using System.Collections.Generic;

namespace ClientDatabase.Services
{
    internal interface IClientService
    {
        void AddClient(Human human);
        void RemoveHuman(int id);
        List<Human> GetClients();
    }
}
