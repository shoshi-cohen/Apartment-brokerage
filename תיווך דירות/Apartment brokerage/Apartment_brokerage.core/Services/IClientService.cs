using Apartment_brokerage.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Core.Services
{
    public interface IClientService
    {
        public List<Client> GetList();
    }
}
