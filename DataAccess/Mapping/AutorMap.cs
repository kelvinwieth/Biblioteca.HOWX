using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccess.Mapping
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("Autor");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasMany(a => a.Livros)
                .WithOne(l => l.Autor)
                .HasForeignKey(l => l.AutorId);

            builder.HasData(GetAutores());
        }

        public List<Autor> GetAutores()
        {
            return new List<Autor>()
            {
                new Autor() { Id = 1, Nome = "George Orwell" },
                new Autor() { Id = 2, Nome = "Victor Hugo" },
                new Autor() { Id = 3, Nome = "Platão" },
                new Autor() { Id = 4, Nome = "Friedrich Nietzsche" },
                new Autor() { Id = 5, Nome = "Jane Austen" },
                new Autor() { Id = 6, Nome = "Laurentino Gomes" },
                new Autor() { Id = 7, Nome = "Sun Tzu" },
                new Autor() { Id = 8, Nome = "Christopher Hilton" },
                new Autor() { Id = 9, Nome = "Pierre Grimal" },
                new Autor() { Id = 10, Nome = "William Gibson" },
                new Autor() { Id = 11, Nome = "Stephen King" },
                new Autor() { Id = 12, Nome = "Patrick Rothfuss" },
                new Autor() { Id = 13, Nome = "J. K. Rowling" },
                new Autor() { Id = 14, Nome = "William Peter Blatty" },
                new Autor() { Id = 15, Nome = "Josh Malerman" },
                new Autor() { Id = 16, Nome = "Luis Felipe Pondé" },
            };
        }
    }
}
