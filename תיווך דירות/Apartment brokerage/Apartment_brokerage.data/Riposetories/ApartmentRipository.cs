using Apartment_brokerage.Core.Entities;
using Apartment_brokerage.Core.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public Apartment? GetById(int id)
        {
            return _context.Apartments.Find(id);
        }

        public Apartment AddApartment(Apartment apartment)
        {
            _context.Apartments.Add(apartment);
            _context.SaveChanges();
            return apartment;
        }

        public Apartment? UpdateApartment(int id, Apartment apartment)
        {
            var a = _context.Apartments.Find(id);

            if (a!= null)
            {
              a.name = apartment.name;
               a.description = apartment.description;
                a.numOfRooms = apartment.numOfRooms;
               a.street = apartment.street;
               a.number = apartment.number;
                a.city = apartment.city;
               a.size = apartment.size;
               a.phoneNumber = apartment.phoneNumber;
                a.email = apartment.email;
               a.price = apartment.price;

                _context.SaveChanges();
            }
            return a;
        }

        public void DeleteApartment(int id)
        {
            var a = _context.Apartments.Find(id);

            if (a != null)
            {
                _context.Apartments.Remove(a);
                _context.SaveChanges();
            }
        }
    }
}

