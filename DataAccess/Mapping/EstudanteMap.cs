using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccess.Mapping
{
    public class EstudanteMap : IEntityTypeConfiguration<Estudante>
    {
        public void Configure(EntityTypeBuilder<Estudante> builder)
        {
            builder.ToTable("Estudante");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Matricula)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(e => e.NomeDoCurso)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(e => e.Senha)
                .HasColumnType("varchar(4)")
                .IsRequired();

            builder.Property(e => e.EstaHabilitado)
                .HasColumnType("boolean")
                .IsRequired();

            builder.HasMany(e => e.Locacoes)
                .WithOne()
                .HasForeignKey(l => l.EstudanteId);

            builder.HasData(GetEstudantes());
        }

        public List<Estudante> GetEstudantes()
        {
            return new List<Estudante>()
            {
                new Estudante()
                {
                    Id = 1,
                    Email = "jose@univali.com",
                    Matricula = "32456789544567",
                    Nome = "José Silva",
                    NomeDoCurso = "Análise e Desenvolvimento de Sistemas",
                    Senha = "1234",
                    EstaHabilitado = true,
                },
                new Estudante()
                {
                    Id = 2,
                    Email = "maria@univali.com",
                    Matricula = "8735983759873",
                    Nome = "Maria Joaquina",
                    NomeDoCurso = "Nutrição",
                    Senha = "2345",
                    EstaHabilitado = true,
                },
                new Estudante()
                {
                    Id = 3,
                    Email = "luis@univali.com",
                    Matricula = "4946137609812",
                    Nome = "Luis Oliveira",
                    NomeDoCurso = "Engenharia Mecânica",
                    Senha = "3456",
                    EstaHabilitado = true,
                },
                new Estudante()
                {
                    Id = 4,
                    Email = "loretz@univali.com",
                    Matricula = "6661235786664",
                    Nome = "Lindomar Pinto",
                    NomeDoCurso = "Artes Visuais",
                    Senha = "4567",
                    EstaHabilitado = true,
                },
                new Estudante()
                {
                    Id = 5,
                    Email = "suce@univali.com",
                    Matricula = "9995836462424",
                    Nome = "Getulio Silva",
                    NomeDoCurso = "Biomedicina",
                    Senha = "5678",
                    EstaHabilitado = true,
                },
                new Estudante()
                {
                    Id = 6,
                    Email = "Larissa@univali.com",
                    Matricula = "6661235786664",
                    Nome = "Larissa da Souza Santos",
                    NomeDoCurso = "Design de Jogos e Entretenimento Digital",
                    Senha = "6789",
                    EstaHabilitado = true,
                },
                 new Estudante()
                {
                    Id = 7,
                    Email = "LeandroPintarelli@univali.com",
                    Matricula = "2158621864152",
                    Nome = "Leandro Pintarelli da Souza",
                    NomeDoCurso = "Estética",
                    Senha = "7890",
                    EstaHabilitado = true,
                },
                  new Estudante()
                {
                    Id = 8,
                    Email = "Peter@Univali.com",
                    Matricula = "1318671238971",
                    Nome = "Peter Santos",
                    NomeDoCurso = "Gestão Pública",
                    Senha = "0369",
                    EstaHabilitado = true,
                },

            };
        }
    }
}
