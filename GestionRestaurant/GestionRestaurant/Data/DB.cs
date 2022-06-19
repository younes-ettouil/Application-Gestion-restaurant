using GestionRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRestaurant.Data
{
    internal class DB : DbContext
    {
        public DB() : base("name=pgcnx"){}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Entity<Table>().ToTable("t_table").HasOptional(t => t.Affecter)
                                                           .WithRequired(a => a.Table);

            
            modelBuilder.Entity<Affecter>().ToTable("t_affecter").HasRequired<Serveur>(a => a.Serveur)
                                                               .WithMany(a => a.Affecters)
                                                               .HasForeignKey(a => a.numero_serveur);
            
            modelBuilder.Entity<Serveur>().ToTable("t_serveur");
            modelBuilder.Entity<Commande>().ToTable("t_commande").HasRequired<Table>(t =>t.Table )
                                                               .WithMany(c => c.Commandees)
                                                               .HasForeignKey(c => c.num_table);
            modelBuilder.Entity<Commande>().ToTable("t_commande").HasOptional(c => c.Contient)
                                                           .WithRequired(c => c.Commande);

            modelBuilder.Entity<Contient>().ToTable("t_contient").HasRequired<Plat>(p => p.Plat)
                                                               .WithMany(c => c.Contients)
                                                               .HasForeignKey(c => c.code_plat);

            modelBuilder.Entity<Plat>().ToTable("t_plat");
        }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Serveur> Serveurs { get; set; }
        public virtual DbSet<Plat> Plats { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Contient> Contients { get; set; }
        public virtual DbSet<Affecter> Affectes { get; set; }

    }
}
