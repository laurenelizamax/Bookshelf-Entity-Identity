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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create a new user for Identity Framework
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            // Create some Authors
            Author author1 = new Author
            {
                Id = 1,
                Name = "Jimmy John",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author1);

            Author author2 = new Author
            {
                Id = 2,
                Name = "Jersey Mike",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author2);

            Author author3 = new Author
            {
                Id = 3,
                Name = "Jared Fogle",
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Author>().HasData(author3);

            // Create some Books

            Book johnBook = new Book
            {
                Id = 1,
                Title = "Free Smells",
                Genre = "Fantasy",
                YearPublished = 1990,
                AuthorId = author1.Id,
                Rating = 1,
                ApplicationUserId = user.Id

            };
            modelBuilder.Entity<Book>().HasData(johnBook);

            Book jerseyBook = new Book
            {
                Id = 2,
                Title = "Jersey Subs",
                Genre = "Sandwiches",
                YearPublished = 2020,
                AuthorId = author2.Id,
                Rating = 2,
                ApplicationUserId = user.Id

            };
            modelBuilder.Entity<Book>().HasData(jerseyBook);

            Book fogleBook = new Book
            {
                Id = 3,
                Title = "How to make a prison sandwiche",
                Genre = "Instructional",
                YearPublished = 2013,
                AuthorId = author3.Id,
                Rating = 1,
                ApplicationUserId = user.Id

            };
            modelBuilder.Entity<Book>().HasData(fogleBook);

            //Create some Comments

            Comment jerseyComment = new Comment
            {
                Id = 1,
                Text = "It smells like Jersey",
                BookId = jerseyBook.Id,
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Comment>().HasData(jerseyComment);

            Comment jimComment = new Comment
            {
                Id = 2,
                Text = "Best book ever!",
                BookId = johnBook.Id,
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Comment>().HasData(jimComment);

            Comment fogleComment = new Comment
            {
                Id = 3,
                Text = "How did he write this book???",
                BookId = fogleBook.Id,
                ApplicationUserId = user.Id
            };
            modelBuilder.Entity<Comment>().HasData(fogleComment);
        }
    }
}
