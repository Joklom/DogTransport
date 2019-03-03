using Microsoft.AspNetCore.Identity;
using System;

namespace DogTransport.Areas.Identity.Models
{
    public class DogTransportUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}