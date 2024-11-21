using Apartment_brokerage.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Data.Riposetories
{
    public class SellingApartmentRipository
    {
        private readonly DataContext _context;

        public SellingApartmentRipository(DataContext context)
        {
            _context = context;
        }
        public List<SellingApartment> GetAll()
        {
            return _context.SellingApartment.ToList();
        }
    }
}
