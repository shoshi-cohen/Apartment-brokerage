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
    }
}

