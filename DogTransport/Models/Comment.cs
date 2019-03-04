using System;
using System.ComponentModel.DataAnnotations;

using DogTransport.Areas.Identity.Models;

namespace DogTransport.Models
{
    public class Comment
    {
        public Guid ID { get; set;}
        public DogTransportUser Author { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

    }
}