using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hot_Mic_Karaoke.Models
{
    public class Business
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Business Name")]
        [Required]
        public string BusinessName { get; set; }

        [Display(Name = "Admin First Name")]
        [Required]
        public string AdminFirstName { get; set; }

        [Display(Name = "Admin Last Name")]
        [Required]
        public string AdminLastName { get; set; }
        [Display(Name = "Business Phone Number")]
        [Required]
        public string BusinessPhoneNumber { get; set; }


        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public IdentityUser AppUser { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("Kevents")]
        public int KeventsId { get; set; }
        public Kevents Kevents { get; set; }
    }
}
