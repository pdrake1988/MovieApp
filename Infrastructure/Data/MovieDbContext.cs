﻿using ApplicationCore.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<MovieCrew> MovieCrew { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}