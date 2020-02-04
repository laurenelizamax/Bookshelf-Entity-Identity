using System;
using System.Collections.Generic;
using System.Text;
using BookShelf.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<BookGenre> BookGenre { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

            //base.OnModelCreating(modelBuilder);

            //// Create a new user for Identity Framework
            //ApplicationUser user = new ApplicationUser
            //{
            //    FirstName = "admin",
            //    LastName = "admin",
            //    UserName = "admin@admin.com",
            //    NormalizedUserName = "ADMIN@ADMIN.COM",
            //    Email = "admin@admin.com",
            //    NormalizedEmail = "ADMIN@ADMIN.COM",
            //    EmailConfirmed = true,
            //    LockoutEnabled = false,
            //    SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
            //    Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            //};
            //var passwordHash = new PasswordHasher<ApplicationUser>();
            //user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            //modelBuilder.Entity<ApplicationUser>().HasData(user);


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookGenre>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookGenres)
                .HasForeignKey(bc => bc.BookId);
            modelBuilder.Entity<BookGenre>()
                .HasOne(bc => bc.Genre)
                .WithMany(c => c.BookGenres)
                .HasForeignKey(bc => bc.GenreId);

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Description = "Fantasy"
                },
                new Genre
                {
                    Id = 2,
                    Description = "Science Fiction"
                },
                new Genre
                {
                    Id = 3,
                    Description = "Horror"
                },
                new Genre
                {
                    Id = 4,
                    Description = "Western"
                },
                new Genre
                {
                    Id = 5,
                    Description = "Romance"
                },
                new Genre
                {
                    Id = 6,
                    Description = "Thriller"
                },
                new Genre
                {
                    Id = 7,
                    Description = "Mystery"
                },
                new Genre
                {
                    Id = 8,
                    Description = "Detective"
                },
                new Genre
                {
                    Id = 9,
                    Description = "Distopia"
                }
            );
        
        }
    }
}
