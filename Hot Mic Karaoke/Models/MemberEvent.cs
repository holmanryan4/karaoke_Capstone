using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hot_Mic_Karaoke.Models
{
    public class MemberEvent
    {

        public int? MemberId { get; set; }
        public Member Member { get; set; }
        public int KaraokeEventId { get; set; }
        public KaraokeEvent KaraokeEvent { get; set; }

    }
}
