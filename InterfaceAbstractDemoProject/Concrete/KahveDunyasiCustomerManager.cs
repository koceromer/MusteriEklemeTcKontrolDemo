using InterfaceAbstractDemoProject.Abstract;
using InterfaceAbstractDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemoProject.Concrete
{
    public class KahveDunyasiCustomerManager : BaseCustomerManager//,ICustomerCheckService
    {
        private ICustomerCheckService _customerCheckService;

        public KahveDunyasiCustomerManager(ICustomerCheckService customerCheckService)
        {
            this._customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            //CheckIfRealPerson(customer);
            if (_customerCheckService.CheckIfRealPerson(customer)) 
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        //public void CheckIfRealPerson(Customer customer)
        //{

        //}
    }
}
