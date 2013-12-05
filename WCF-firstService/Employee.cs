using System;
using System.Runtime.Serialization;

namespace WCF_firstService
{
    public enum Department
    {
        Manager,
        ShelfFiller,
        Checkout
    }
    
    [DataContract]
    public class Employee
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public string Forename { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public Department Department { get; set; }
    }
}