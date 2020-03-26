using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Hot_Mic_Karaoke.Models;

namespace Hot_Mic_Karaoke.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        //C:\Projects\Hot Mic Karaoke\Hot Mic Karaoke\Views\Home\
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                 .HasOne<AppUserM>(a => a.Sender)
                 .WithMany(d => d.Messages)
                 .HasForeignKey(d => d.UserID);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Member",
                        NormalizedName = "MEMBER"
                    },
                     new IdentityRole
                     {
                         Name = "Business",
                         NormalizedName = "BUSINESS",

                     }
                    );

            builder.Entity<MemberEvent>()
                .HasKey(ke => new { ke.MemberId, ke.KaraokeEventId });
            builder.Entity<MemberEvent>()
                .HasOne(ke => ke.Member)
                .WithMany(m => m.MemberEvents)
                .HasForeignKey(ke => ke.MemberId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.Entity<MemberEvent>()
                .HasOne(ke => ke.KaraokeEvent)
                .WithMany(me => me.MemberEvents)
                .HasForeignKey(k => k.KaraokeEventId)
                .OnDelete(DeleteBehavior.Restrict);

            
        }
        public DbSet<Hot_Mic_Karaoke.Models.Member> Member { get; set; }
        public DbSet<Hot_Mic_Karaoke.Models.Business> Business { get; set; }
        public DbSet<Hot_Mic_Karaoke.Models.SongList> SongList { get; set; }
        public DbSet<Hot_Mic_Karaoke.Models.Message> Messages { get; set; }
        //public DbSet<Hot_Mic_Karaoke.Models.KaraokeEvent> KaraokeEvents{ get; set; }

    }
}
