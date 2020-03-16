using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hot_Mic_Karaoke.Models
{
    public class Kevents
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Event Location")]
        [Required]
        public string EventLocation { get; set; }

        [Display(Name = "Date and Time")]
        [Required]
        public DateTime DateAndTime { get; set; }
    }
}
