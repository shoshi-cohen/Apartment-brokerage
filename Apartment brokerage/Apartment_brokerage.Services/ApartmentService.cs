

using Apartment_brokerage.Core.Entities;
using Apartment_brokerage.Core.Repositories;
using Apartment_brokerage.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace partment_brokerage.Service
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRipository _apartmentRepository;
        public ApartmentService(IApartmentRipository apartmentRepository)
        {
            _apartmentRepository = apartmentRepository;
        }
        public List<Apartment> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _apartmentRepository.GetAll();
        }
    }
}


