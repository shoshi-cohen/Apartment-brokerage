using Apartment_brokerage.Core.Entities;
using Apartment_brokerage.Core.Repositories;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public SellingApartment? GetById(int id)
        {
            return _context.SellingApartment.Find(id);
        }

        public SellingApartment AddSellingApartment(SellingApartment SellingApartment)
        {
            _context.SellingApartment.Add(SellingApartment);
            _context.SaveChanges();
            return SellingApartment;
        }

        public SellingApartment? UpdateSellingApartment(int id, SellingApartment SellingApartment)
        {
            var sa = _context.SellingApartment.Find(id);

            if (sa != null)
            {
               sa.idBueyr = SellingApartment.idBueyr;
                sa.nameSeller = SellingApartment.nameBueyr;
                sa.idSeller = SellingApartment.idSeller;
                sa.nameBueyr = SellingApartment.nameSeller;
                sa.idApartment = SellingApartment.idApartment;
                sa.phoneBuyer = SellingApartment.phoneBuyer;
                sa.phoneSeller = SellingApartment.phoneSeller;

                _context.SaveChanges();
            }
            return sa;
        }

        public void DeleteSellingApartment(int id)
        {
            var sa = _context.SellingApartment.Find(id);

            if (sa != null)
            {
                _context.SellingApartment.Remove(sa);
                _context.SaveChanges();
            }
        }

    }
}
