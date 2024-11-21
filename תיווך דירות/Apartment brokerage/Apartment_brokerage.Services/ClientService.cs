
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
    public class ClientService : IClientService
    {
        private readonly IclientRepository _clientRepository;
        public ClientService(IclientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public List<Client> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _clientRepository.GetAll();
        }
    }
}