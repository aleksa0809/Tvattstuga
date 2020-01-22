using System;
using System.ComponentModel.DataAnnotations;


namespace app.Models
{
    public class Tvatt
    { 
        
        public int Id { get; set; }
        [Required]
        public DateTime TvattDate { get; set; }
        [Required]
        public string User { get; set; }
    }
}
