using InterfaceAbstractDemoProject.Abstract;
using InterfaceAbstractDemoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemoProject.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //return true;
            //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();//böyle yaparsan mernise bağlı olursun ve sıkıntılar ortaya çıkabiblir
            return true;
        }

    }
}
