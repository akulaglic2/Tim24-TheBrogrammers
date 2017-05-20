using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ProjekatKino.Models
    {
    class KinoDbContext : DbContext
        {
        public DbSet<Korisnik> korisnici { get; set; }
        public DbSet<Uposlenik> uposlenici { get; set; }
        public DbSet<Film> filmovi { get; set; }


        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
            {
            string databaseFilePath = "ProjekatKinoBaza.db";
            try
                {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path,
                databaseFilePath);
                }
            catch (InvalidOperationException) { }
            //Sqlite baza
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
            }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
            { }


        }
    }
