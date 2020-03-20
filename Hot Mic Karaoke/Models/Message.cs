﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hot_Mic_Karaoke.Models
{
    public class Message
    {
        
        public int Id { get; set; }
        [Required]
        public string UserName{ get; set; }
        [Required]
        public string text { get; set; }
        public DateTime When { get; set; }

        public string UserID { get; set; }
        public virtual AppUserM Sender { get; set; }

        public Message()
        {
            When = DateTime.Now;
        }
      
    }
}
