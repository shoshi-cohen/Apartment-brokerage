﻿using Apartment_brokerage.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment_brokerage.Core.Repositories
{
    public interface IclientRepository
    {
        public List<Client> GetAll();
    }
}
