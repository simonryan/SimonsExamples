using System;
using System.Runtime.Serialization;

namespace Domain
{
    [DataContract]
    public class Journey
    {
        [DataMember]
        public string DepartureStation { get; set; }
        [DataMember]
        public string ArrivalStation { get; set; }
        [DataMember]
        public short Platform { get; set; }
        [DataMember]
        public DateTime DepartureTime { get; set; }
        [DataMember]
        public DateTime ArrivalTime { get; set; }
    }
}
