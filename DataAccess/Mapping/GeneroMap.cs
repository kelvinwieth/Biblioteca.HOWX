using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccess.Mapping
{
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Genero");

            builder.HasKey(g => g.Id);

            builder.Property(g => g.Nome)
                .HasColumnType("varchar(100)");

            builder.HasMany(g => g.Livros)
                .WithOne(l => l.Genero)
                .HasForeignKey(l => l.GeneroId);

            builder.HasData(GetGeneros());
        }

        public List<Genero> GetGeneros()
        {
            return new List<Genero>()
            {
                new Genero() { Id = 1, Nome = "Drama" },
                new Genero() { Id = 2, Nome = "Filosofia" },
                new Genero() { Id = 3, Nome = "Romance" },
                new Genero() { Id = 4, Nome = "História" },
                new Genero() { Id = 5, Nome = "Biografia" },
                new Genero() { Id = 6, Nome = "Ficção Científica" },
                new Genero() { Id = 7, Nome = "Suspense" },
                new Genero() { Id = 8, Nome = "Aventura" },
                new Genero() { Id = 9, Nome = "Terror"},

            };
        }
    }
}
