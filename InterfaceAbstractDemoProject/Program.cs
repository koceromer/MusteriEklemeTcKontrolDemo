using InterfaceAbstractDemoProject.Abstract;
using InterfaceAbstractDemoProject.Adapters;
using InterfaceAbstractDemoProject.Concrete;
using InterfaceAbstractDemoProject.Entities;

namespace InterfaceAbstractDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new KahveDunyasiCustomerManager(new MernisServiceAdapter());//NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2001, 9, 24),FirstName="Ömer",LastName="Köçer",NationaltId="6594568795" });

            Console.ReadLine();
        }
    }
}