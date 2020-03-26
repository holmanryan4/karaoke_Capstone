using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hot_Mic_Karaoke.Models
{
    public class SongList 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Comments { get; set; }
        [Required]
        public string Rating { get; set; }
        
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member  { get; set; }
    }
}
