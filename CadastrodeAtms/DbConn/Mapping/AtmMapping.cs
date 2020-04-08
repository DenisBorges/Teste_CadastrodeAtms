using CadastrodeAtms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.DbConn.Mapping
{
    public class AtmMapping : IEntityTypeConfiguration<AtmModel>
    {
        public void Configure(EntityTypeBuilder<AtmModel> builder)
        {
            builder.ToTable("ATMs");

            builder.HasKey(x => x.id );

        
            builder.Property(x => x.id).HasColumnName("atmID").ValueGeneratedOnAdd();
            builder.Property(x => x.AtmPc).HasColumnName("atmPC");
            builder.Property(x => x.DataCadastro).HasColumnName("atmDTCADASTRO");
            builder.Property(x => x.AtmNome).HasColumnName("atmNOME");
            builder.Property(x => x.AtmPa).HasColumnName("atmPA");
            builder.Property(x => x.AtmEndereco).HasColumnName("atmENDERECO");
            builder.Property(x => x.AtmComplemento).HasColumnName("atmCOMPLEMENTO");
            builder.Property(x => x.AtmBairro).HasColumnName("atmBAIRRO");
            builder.Property(x => x.AtmCidade).HasColumnName("atmCIDADE");
            builder.Property(x => x.AtmUf).HasColumnName("atmUF");
            builder.Property(x => x.AtmCep).HasColumnName("atmCEP");
            builder.Property(x => x.AtmPontoRef).HasColumnName("atmPONTOREF");
            builder.Property(x => x.AtmLatitude).HasColumnName("atmLATITUDE");
            builder.Property(x => x.AtmLongitude).HasColumnName("atmLONGITUDE");
            builder.Property(x => x.AtmUf).HasColumnName("atmUF");

            builder.Ignore(x => x.Uf);

            builder.Ignore(x => x.Cidade);


            builder.Property(x => x.id).ValueGeneratedOnAdd();


            builder.HasOne<MunicipioModel>(a => a.Cidade)
                .WithMany(m => m.atms)
                .HasForeignKey(a => a.AtmCidade);

            builder.HasOne<UfModel>(a => a.Uf)
          .WithMany(m => m.atms)
          .HasForeignKey(a => a.AtmUf);

        }
    }
}
