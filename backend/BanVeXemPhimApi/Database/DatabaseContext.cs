﻿using BanVeXemPhimApi.Models;
using BanVeXemPhimApi.Seeder;
using Microsoft.EntityFrameworkCore;

namespace BanVeXemPhimApi.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }


        #region User
        public DbSet<User> users { get; set; }
        #endregion

        #region Admin
        public DbSet<Admin> admins { get; set; }
        #endregion

        #region Movie
        public DbSet<Movie> movies { get; set; }
        #endregion

        #region Cinema
        public DbSet<Cinema> cenimas { get; set; }
        #endregion

        #region Cinema
        public DbSet<Schedule> schedules { get; set; }
        #endregion

        public static void UpdateDatabase(DatabaseContext context)
        {
            context.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var sqlConnection = "Server=localhost;Port=3306;Database=website_ban_ve_xem_phim;Uid=root;Pwd=;MaximumPoolSize=500;";
                optionsBuilder.UseMySql(sqlConnection,
                    MySqlServerVersion.LatestSupportedServerVersion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region User
            new UserSeeder(modelBuilder).SeedData();
            #endregion

            #region Movie
            new MovieSeeder(modelBuilder).SeedData();
            #endregion

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}