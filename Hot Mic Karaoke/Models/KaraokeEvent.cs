using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hot_Mic_Karaoke.Models
{
    public class KaraokeEvent
    {
        
        public int Id { get; set; }

        [Display(Name = "Name of Event ")]
        [Required]
        public string EventName { get; set; }

        [Display(Name = "Event Description")]
        [Required]
        public DateTime EventInfo { get; set; }

        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public IdentityUser AppUser { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        
        public ICollection<MemberEvent> MemberEvents { get; set; }
    }
}
