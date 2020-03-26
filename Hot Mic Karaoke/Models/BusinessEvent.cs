using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hot_Mic_Karaoke.Models
{
    public class BusinessEvent
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name of Event")]
        [Required]
        public string EventName { get; set; }

        [Display(Name = "Event Location")]
        [Required]
        public string EventLocation { get; set; }

        [Display(Name = "Date and Time")]
        [Required]
        public DateTime DateAndTime { get; set; }

        [Display(Name = "Event Description")]
        [Required]
        public string EventInfo { get; set; }

        [ForeignKey("Business")]
        public int BusinessId { get; set; }
        public Business Business { get; set; }
    }
}
