using CadastrodeAtms.DbConn.Mapping;
using CadastrodeAtms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.DbConn
{
    public class Conexao : DbContext
    {
        public Conexao() { }

        public Conexao(DbContextOptions<Conexao> options) : base(options) { }

        public DbSet<AtmModel> Atm { get; set; }

        public DbSet<MunicipioModel> Municipio { get; set; }
        public DbSet<UfModel> Uf { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration<AtmModel>(new AtmMapping());
            modelBuilder.ApplyConfiguration<UfModel>(new UfMapping());
            modelBuilder.ApplyConfiguration<MunicipioModel>(new MunicipioMapping());
           

            base.OnModelCreating(modelBuilder);
        }


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }


                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
