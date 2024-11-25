using Apartment_brokerage.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Core.Services
{
    public interface IClientService
    {
        public List<Client> GetList();
        public Client GetClientsById(int id);
        public Client AddClients(Client client);

        public Client UpdateClients(int id, Client client);
        public void DeleteClients(int id);
    }
}
