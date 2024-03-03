using InterfaceAbstractDemoProject.Abstract;
using InterfaceAbstractDemoProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceAbstractDemoProject.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(
                customer.NationaltId, 
                customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), 
                customer.DateOfBirth.Year);
        }
    }
}
