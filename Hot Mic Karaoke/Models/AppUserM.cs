using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hot_Mic_Karaoke.Models
{
    public class AppUserM : IdentityUser
    {
        public AppUserM()
        {
            Messages = new HashSet<Message>();
        }
        // 1-* AppUser || Message
        public virtual ICollection<Message> Messages { get; set; }
    }
}
