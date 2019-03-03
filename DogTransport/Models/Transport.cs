using System;
using System.ComponentModel.DataAnnotations;

using DogTransport.Areas.Identity.Models;

namespace DogTransport.Models
{
    public class Transport
    {
        public Guid ID { get; set;}
        public DogTransportUser Organizer { get; set; }
        public Location Origin { get; set; }
        public Location Destination { get; set; }
        public DateTime Date { get; set; }
        
    }
}