﻿using InterfaceAbstractDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemoProject.Abstract
{
    public abstract class BaseCustomerManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save To Db  :" + customer.FirstName);
        }
    }
}
