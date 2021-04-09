using GestioneSpese.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneSpesa.GestioneSpeseEF.Context
{
    public class GestioneSpeseContext : DbContext
    {
        public GestioneSpeseContext() : base() { }
        public GestioneSpeseContext(DbContextOptions<GestioneSpeseContext> options) : base(options) { }

        public DbSet<Spese> Spesa { get; set; }
        public DbSet<Categoria> Categorie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Persist Security Info = False;
                                           Integrated Security = true;
                                           Initial Catalog = GestioneSpese;
                                           Server = WINAPFC01X4OMES");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spese>()
                        .HasOne(c => c.Categoria)
                        .WithMany(s => s.Spesa);

        }
    }
}