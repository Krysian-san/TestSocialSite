using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Activity
    {
        [Key]
        public Guid Id {get;set;}
        public string Name {get;set;}

        public DateTime Date { get; set; }

        // [Required]
        public string Description { get; set; }

        public string Category {get;set;}

        public string City {get;set;}

        public string Venue {get;set;}
        
    }
}