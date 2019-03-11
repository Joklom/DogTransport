using System;
using System.ComponentModel.DataAnnotations;
using DogTransport.Areas.Identity.Data;

namespace DogTransport.Models
{
    public class Rescue
    {
        public Guid ID { get; set;}
        public AspNetUser[] Admins { get; set; }
    }
}