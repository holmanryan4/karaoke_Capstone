using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hot_Mic_Karaoke.Models;

namespace Hot_Mic_Karaoke.Models
{
    public class MemberMessages : SongList
    {
        public IEnumerable<Message> Messages { get; set; }
    }
}
