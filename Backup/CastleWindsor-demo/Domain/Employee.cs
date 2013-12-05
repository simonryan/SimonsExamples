using System;

namespace CastleWindsor_demo.Domain
{
    public enum Department
    {
        Manager,
        ShelfFiller,
        Checkout
    }
    
    public class Employee
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Department Department { get; set; }
    }
}