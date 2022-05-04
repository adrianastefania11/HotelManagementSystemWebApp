using HotelManagementSystem.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data
{
    public class HotelContext : IdentityDbContext<ApplicationUser, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public HotelContext(DbContextOptions<HotelContext> options ) : base(options) { }

       
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<RoomFeature> RoomFeatures { get; set; }
        public DbSet<SessionToken> SessionTokens { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomFeature>().HasKey(x => new { x.RoomId, x.FeatureId });

            modelBuilder.Entity<RoomFeature>()
                .HasOne(rf => rf.Room)
                .WithMany(r => r.RoomFeatures)
                .HasForeignKey(rf => rf.RoomId);

            modelBuilder.Entity<RoomFeature>()
                .HasOne(rf => rf.Feature)
                .WithMany(f => f.RoomFeatures)
                .HasForeignKey(rf => rf.FeatureId);


            modelBuilder.Entity<Room>()
                .HasOne(r => r.RoomType)
                .WithOne(rt => rt.Room);

            modelBuilder.Entity<ApplicationUser>()
               .HasMany(a => a.Bookings)
               .WithOne(b => b.ApplicationUser);

            modelBuilder.Entity<Booking>()
              .HasMany(b => b.Rooms)
              .WithOne(r => r.Booking);
             
            modelBuilder.Entity<Room>()
             .HasMany(r => r.Reviews)
            .WithOne(rw => rw.Room);

            modelBuilder.Entity<Room>()
            .HasMany(r => r.RoomImages)
             .WithOne(i => i.Room);

            modelBuilder.Entity<UserRole>(ur =>
            {
                ur.HasKey(ur => new { ur.UserId, ur.RoleId });

                ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId);
                ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId);

            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
