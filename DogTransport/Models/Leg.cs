using System;
using System.ComponentModel.DataAnnotations;
using DogTransport.Areas.Identity.Data;

namespace DogTransport.Models
{
    public class Leg
    {
        public Guid ID { get; set; }
        public AspNetUser Organizer { get; set; }
        public Location Origin { get; set; }
        public Location Destination { get; set; }
        public DateTime Date { get; set; }
        public bool Fed { get; set; }
        public bool Watered { get; set; }
        public bool Bathroom { get; set; }
        public Dog[] Dogs { get; set; }
        public Comment[] Comments { get; set; }
    }
}
