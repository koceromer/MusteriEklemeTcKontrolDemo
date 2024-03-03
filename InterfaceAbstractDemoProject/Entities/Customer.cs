using InterfaceAbstractDemoProject.Abstract;

namespace InterfaceAbstractDemoProject.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string NationaltId { get; set; }


    }
}