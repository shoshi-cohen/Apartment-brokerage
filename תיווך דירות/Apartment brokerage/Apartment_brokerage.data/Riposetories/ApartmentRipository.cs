using Apartment_brokerage.Core.Entities;
using Apartment_brokerage.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Data.Riposetories
{
    public class ApartmentRipository : IApartmentRipository
    {
        private readonly DataContext _context;

        public ApartmentRipository(DataContext context)
        {
            _context = context;
        }
        public List<Apartment> GetAll()
        {
            return _context.Apartments.ToList();
        }
    }
}

