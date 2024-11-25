using Apartment_brokerage.Core.Entities;
using Apartment_brokerage.Core.Repositories;
using Apartment_brokerage.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Service
{
    public class SellingApartmentService:ISellingApartmentService
    {
        private readonly ISellingApartmentRipository _sellingApartmentRipository;
        public SellingApartmentService(ISellingApartmentRipository sellingApartmentRipository)
        {
            _sellingApartmentRipository = sellingApartmentRipository;
        }
        public List<SellingApartment> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _sellingApartmentRipository.GetAll();
        }
      

        public SellingApartment AddSellingApartments(SellingApartment SellingApartment)
        {
            
            return _sellingApartmentRipository.AddSellingApartment(SellingApartment);
        }

       

        public SellingApartment? GetSellingApartmentsById(int id)
        {
            return _sellingApartmentRipository.GetById(id);
        }

        public SellingApartment UpdateSellingApartments(int id, SellingApartment SellingApartment)
        {
            return _sellingApartmentRipository.UpdateSellingApartment(id, SellingApartment);
        }

        public void DeleteSellingApartments(int id)
        {
            _sellingApartmentRipository.DeleteSellingApartment(id);
        }
    }
}

