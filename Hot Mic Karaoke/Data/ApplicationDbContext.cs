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
            
        }
        public DbSet<Hot_Mic_Karaoke.Models.Member> Member { get; set; }
        public DbSet<Hot_Mic_Karaoke.Models.Business> Business { get; set; }
        public DbSet<Hot_Mic_Karaoke.Models.Kevents> Kevents { get; set; }
        public DbSet<Hot_Mic_Karaoke.Models.Message> Messages { get; set; }
    }
}
