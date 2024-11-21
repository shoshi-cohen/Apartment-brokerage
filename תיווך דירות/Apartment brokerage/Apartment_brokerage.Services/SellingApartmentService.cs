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
    }
}

