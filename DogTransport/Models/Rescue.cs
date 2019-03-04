using System;
using System.ComponentModel.DataAnnotations;

using DogTransport.Areas.Identity.Models;

namespace DogTransport.Models
{
    public class Rescue
    {
        public Guid ID { get; set;}
        public DogTransportUser[] Admins { get; set; }
    }
}