using System;
using System.ComponentModel.DataAnnotations;
using DogTransport.Areas.Identity.Data;

namespace DogTransport.Models
{
    public class Transport
    {
        public Guid ID { get; set;}
        public AspNetUser Organizer { get; set; }
        public Location Origin { get; set; }
        public Location Destination { get; set; }
        public DateTime Date { get; set; }
        public Leg[] Legs { get; set; }
        public Comment[] Comments { get; set; }
    }
}