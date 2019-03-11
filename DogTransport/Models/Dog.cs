using System;
using System.ComponentModel.DataAnnotations;
using DogTransport.Areas.Identity.Data;

namespace DogTransport.Models
{
    public class Dog
    {
        public Guid ID { get; set;}
        public string Name { get; set; }
        public AspNetUser Owner { get; set; }
        public string SpecialNeeds { get; set; }
        public bool BiteHistory { get; set; }
        public bool kennel { get; set; }
        public bool Aggressive { get; set; }
        public string Description { get; set; }
    }
}