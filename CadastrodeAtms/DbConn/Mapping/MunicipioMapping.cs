using CadastrodeAtms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.DbConn.Mapping
{
    public class MunicipioMapping : IEntityTypeConfiguration<MunicipioModel>
    {
        public void Configure(EntityTypeBuilder<MunicipioModel> builder)
        {
            builder.ToTable("Municipios");

            builder.HasKey(x => x.id );

            builder.Property(x => x.id).ValueGeneratedOnAdd().HasColumnName("MunID");
            builder.Property(x => x.MunNome).ValueGeneratedOnAdd().HasColumnName("MunNOME");
            builder.Property(x => x.MunUf).ValueGeneratedOnAdd().HasColumnName("MunUF");
            builder.Property(x => x.MunIss).ValueGeneratedOnAdd().HasColumnName("MunISS");
            builder.Property(x => x.MunIcms).ValueGeneratedOnAdd().HasColumnName("MunICMS");
            builder.Property(x => x.MunIcmsInterno).ValueGeneratedOnAdd().HasColumnName("MunICMSInterno");

            builder.Ignore(x => x.atms);
            builder.Ignore(x => x.uf);

            builder.HasOne<UfModel>(x => x.uf)
                .WithMany(x => x.municipios)
                .HasForeignKey(x => x.MunUf);

            builder.HasMany<AtmModel>(x => x.atms)
                .WithOne(x => x.Cidade)
                .HasForeignKey(x => x.AtmCidade);

            builder.HasData(
                new MunicipioModel(1, "São Paulo",19),
                new MunicipioModel(2, "Guarulhos", 19)
                );

        }
    }
}
