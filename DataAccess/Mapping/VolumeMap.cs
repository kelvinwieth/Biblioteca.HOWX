using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccess.Mapping
{
    public class VolumeMap : IEntityTypeConfiguration<Volume>
    {
        public void Configure(EntityTypeBuilder<Volume> builder)
        {
            builder.ToTable("Volume");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.EstaDisponivel)
                .HasColumnType("boolean")
                .IsRequired();

            builder.HasOne(v => v.Livro)
                .WithMany(l => l.Volumes)
                .HasForeignKey(v => v.LivroId)
                .IsRequired();

            builder.HasData(GetVolumes());
        }

        public List<Volume> GetVolumes()
        {
            return new List<Volume>()
            {

                // Livro A revolução dos bichos

                new Volume() { Id = 1, LivroId = 1, EstaDisponivel = true },
                new Volume() { Id = 2, LivroId = 1, EstaDisponivel = true },
                new Volume() { Id = 3, LivroId = 1, EstaDisponivel = true },

                // Livro Os Miseráveis

                new Volume() { Id = 4, LivroId = 2, EstaDisponivel = true },
                new Volume() { Id = 5, LivroId = 2, EstaDisponivel = true },
                new Volume() { Id = 6, LivroId = 2, EstaDisponivel = true },

                // Livro A República 

                new Volume() { Id = 7, LivroId = 3, EstaDisponivel = true },
                new Volume() { Id = 8, LivroId = 3, EstaDisponivel = true },
                new Volume() { Id = 9, LivroId = 3, EstaDisponivel = true },

                // Além do Bem e do Mal

                new Volume() { Id = 10, LivroId = 4, EstaDisponivel = true },
                new Volume() { Id = 11, LivroId = 4, EstaDisponivel = true },
                new Volume() { Id = 12, LivroId = 4, EstaDisponivel = true },

                // Orgulho e Preconceito

                new Volume() { Id = 13, LivroId = 5, EstaDisponivel = true },
                new Volume() { Id = 14, LivroId = 5, EstaDisponivel = true },
                new Volume() { Id = 15, LivroId = 5, EstaDisponivel = true },

                // Northanger Abbey

                new Volume() { Id = 16, LivroId = 6, EstaDisponivel = true },
                new Volume() { Id = 17, LivroId = 6, EstaDisponivel = true },
                new Volume() { Id = 18, LivroId = 6, EstaDisponivel = true },

                // 1822 

                new Volume() { Id = 19, LivroId = 7, EstaDisponivel = true },
                new Volume() { Id = 20, LivroId = 7, EstaDisponivel = true },
                new Volume() { Id = 21, LivroId = 7, EstaDisponivel = true },

                // A Arte da Guerra


                new Volume() { Id = 22, LivroId = 8, EstaDisponivel = true },
                new Volume() { Id = 23, LivroId = 8, EstaDisponivel = true },
                new Volume() { Id = 24, LivroId = 8, EstaDisponivel = true },

                // Ayrton Senna
                
                new Volume() { Id = 25, LivroId = 9, EstaDisponivel = true },
                new Volume() { Id = 26, LivroId = 9, EstaDisponivel = true },
                new Volume() { Id = 27, LivroId = 9, EstaDisponivel = true },

                // Marco Aurelio: o Imperador filósofo 

                new Volume() { Id = 28, LivroId = 10, EstaDisponivel = true },
                new Volume() { Id = 29, LivroId = 10, EstaDisponivel = true },
                new Volume() { Id = 30, LivroId = 10, EstaDisponivel = true },

                // Neuromancer

                new Volume() { Id = 31, LivroId = 11, EstaDisponivel = true },
                new Volume() { Id = 32, LivroId = 11, EstaDisponivel = true },
                new Volume() { Id = 33, LivroId = 11, EstaDisponivel = true },

                // 1984

                new Volume() { Id = 34, LivroId = 12, EstaDisponivel = true },
                new Volume() { Id = 35, LivroId = 12, EstaDisponivel = true },
                new Volume() { Id = 36, LivroId = 12, EstaDisponivel = true },

                // It - a coisa

                new Volume() { Id = 37, LivroId = 13, EstaDisponivel = true },
                new Volume() { Id = 38, LivroId = 13, EstaDisponivel = true },
                new Volume() { Id = 39, LivroId = 13, EstaDisponivel = true },

                // The Outsider

                new Volume() { Id = 40, LivroId = 14, EstaDisponivel = true },
                new Volume() { Id = 41, LivroId = 14, EstaDisponivel = true },
                new Volume() { Id = 42, LivroId = 14, EstaDisponivel = true },

                // O Nome do Vento

                new Volume() { Id = 43, LivroId = 15, EstaDisponivel = true },
                new Volume() { Id = 44, LivroId = 15, EstaDisponivel = true },
                new Volume() { Id = 45, LivroId = 15, EstaDisponivel = true },

                // Harry Potter e a Pedra Filosofal

                new Volume() { Id = 46, LivroId = 16, EstaDisponivel = true },
                new Volume() { Id = 47, LivroId = 16, EstaDisponivel = true },
                new Volume() { Id = 48, LivroId = 16, EstaDisponivel = true },

                // O Exorcista 

                new Volume() { Id = 49, LivroId = 17, EstaDisponivel = true },
                new Volume() { Id = 50, LivroId = 17, EstaDisponivel = true },
                new Volume() { Id = 51, LivroId = 17, EstaDisponivel = true },

                // Caixa de Pássaros 

                new Volume() { Id = 52, LivroId = 18, EstaDisponivel = true },
                new Volume() { Id = 53, LivroId = 18, EstaDisponivel = true },
                new Volume() { Id = 54, LivroId = 18, EstaDisponivel = true },

                // 1889

                new Volume() { Id = 55, LivroId = 19, EstaDisponivel = true },
                new Volume() { Id = 56, LivroId = 19, EstaDisponivel = true },
                new Volume() { Id = 57, LivroId = 19, EstaDisponivel = true },

                // Filosofia para corajosos

                new Volume() { Id = 58, LivroId = 20, EstaDisponivel = true },
                new Volume() { Id = 59, LivroId = 20, EstaDisponivel = true },
                new Volume() { Id = 60, LivroId = 20, EstaDisponivel = true },
            };
        }
    }
}
