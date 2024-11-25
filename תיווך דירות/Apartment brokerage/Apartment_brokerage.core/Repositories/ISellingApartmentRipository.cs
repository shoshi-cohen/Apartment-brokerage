using Apartment_brokerage.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Core.Repositories
{
    public interface ISellingApartmentRipository
    {
        public List<SellingApartment> GetAll();          
        public SellingApartment GetById(int id);
        public SellingApartment AddSellingApartment(SellingApartment s);

        public SellingApartment UpdateSellingApartment(int id, SellingApartment SellingApartment);
        public void DeleteSellingApartment(int id);


    }
}
