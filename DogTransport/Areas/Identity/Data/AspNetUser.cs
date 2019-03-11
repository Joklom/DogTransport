using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

using DogTransport.Models;

namespace DogTransport.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AspNetUser class
    public class AspNetUser : IdentityUser
    {
        [Required]
        public string First { get; set; }
        [Required]
        public string Last { get; set; }
        public Rescue Rescue { get; set; }
    }
}
