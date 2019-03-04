using System;
using System.ComponentModel.DataAnnotations;

namespace DogTransport.Models
{
    public class Location
    {
        public Guid ID { get; set;}
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Description { get; set; }
    }
}