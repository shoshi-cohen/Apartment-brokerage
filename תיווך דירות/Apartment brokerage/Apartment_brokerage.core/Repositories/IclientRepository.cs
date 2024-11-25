using Apartment_brokerage.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Core.Repositories
{
    public interface IclientRepository
    {
        public List<Client> GetAll();
        public Client GetById(int id);
        public Client AddClient(Client s);

        public Client UpdateClient(int id, Client client);
        public void DeleteClient(int id);
    }
}
