using CadastrodeAtms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeAtms.DbConn.Mapping
{
    public class UfMapping : IEntityTypeConfiguration<UfModel>
    {
        public void Configure(EntityTypeBuilder<UfModel> builder)
        {
            builder.ToTable("UFS");

            builder.HasKey(x =>  x.id);

            builder.Property(x => x.id).ValueGeneratedOnAdd();


            builder.HasMany<MunicipioModel>(x => x.municipios)
                .WithOne(x => x.uf)
                .HasForeignKey(x => x.MunUf);

            builder.HasMany<AtmModel>(x => x.atms)
                .WithOne(x => x.Uf)
                .HasForeignKey(x => x.AtmUf);

            builder.Ignore(x => x.municipios);
            builder.Ignore(x => x.atms);

            builder.Property(x => x.DataCadastro).HasDefaultValueSql("date('now')");

            builder.HasData(
                new UfModel(1, "AC", "Acre"),
                new UfModel(2, "AM", "Amazonas"),
                new UfModel(3, "RR", "Roraima"),
                new UfModel(4, "PA", "Pará"),
                new UfModel(5, "AP", "Amapá"),
                new UfModel(6, "TO", "Tocantins"),
                new UfModel(7, "MA", "Maranhão"),
                new UfModel(8, "PI", "Piauí"),
                new UfModel(9, "CE", "Ceará"),
                new UfModel(10, "RN", "Rio Grande do Norte"),
                new UfModel(11, "PB", "Paraíba"),
                new UfModel(12, "PE", "Pernambuco"),
                new UfModel(13, "AL", "Alagoas"),
                new UfModel(14, "SE", "Sergipe"),
                new UfModel(15, "BA", "Bahia"),
                new UfModel(16, "MG", "Minas Gerais"),
                new UfModel(17, "ES", "Espírito Santo"),
                new UfModel(18, "RJ", "Rio de Janeiro"),
                new UfModel(19, "SP", "São Paulo"),
                new UfModel(20, "PR", "Paraná"),
                new UfModel(21, "SC", "Santa Catarina"),
                new UfModel(22, "RS", "Rio Grande do Sul"),
                new UfModel(23, "MS", "Mato Grosso do Sul"),
                new UfModel(24, "MT", "Mato Grosso"),
                new UfModel(25, "GO", "Goiás"),
                new UfModel(26, "DF", "Distrito Federal"),
                new UfModel(27, "RO", "Rondônia")
                );

        }
    }
}
