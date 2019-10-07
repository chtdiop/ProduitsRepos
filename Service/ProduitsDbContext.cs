using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Catalogue_Produits.Service
{
    public class ProduitsDbContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }
       
        public ProduitsDbContext(DbContextOptions<ProduitsDbContext> options) : base(options)
        {
           // optionsBuilder.UseSqlServer(@"server=THALES\SQLEXPRESS; Database=Produit_Cat; Trusted_Connection=True", builder => builder.UseRowNumberForPaging());
            Database.EnsureCreated();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
         //   optionsBuilder.UseSqlServer(@"server=THALES\SQLEXPRESS; Database=Produit_Cat; Trusted_Connection=True", builder => builder.UseRowNumberForPaging());
        //}
    }
}
