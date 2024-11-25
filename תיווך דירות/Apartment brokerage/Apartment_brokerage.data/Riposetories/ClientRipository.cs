using Apartment_brokerage.Core.Entities;
using Apartment_brokerage.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Data.Riposetories
{
    public class ClientRipository : IclientRepository
    {
        private readonly DataContext _context;

        public ClientRipository(DataContext context)
        {
            _context = context;
        }
        public List<Client> GetAll()
        {
            return _context.Client.ToList();
        }
        public Client? GetById(int id)
        {
            return _context.Client.Find(id);
        }

        public Client AddClient(Client client)
        {
            _context.Client.Add(client);
            _context.SaveChanges();
            return client;
        }

        public Client? UpdateClient(int id, Client client)
        {
            var c= _context.Client.Find(id);

            if (c != null)
            {
                c.name = client.name;
                c.phone = client.phone;
                c.email = client.email;
               
                _context.SaveChanges();
            }
            return c;
        }

        public void DeleteClient(int id)
        {
            var c = _context.Client.Find(id);

            if (c != null)
            {
                _context.Client.Remove(c);
                _context.SaveChanges();
            }
        }
    }
}

