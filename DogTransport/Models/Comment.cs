using System;
using System.ComponentModel.DataAnnotations;
using DogTransport.Areas.Identity.Data;

namespace DogTransport.Models
{
    public class Comment
    {
        public Guid ID { get; set;}
        public AspNetUser Author { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }

    }
}