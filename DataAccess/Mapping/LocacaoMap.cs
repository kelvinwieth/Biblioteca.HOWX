using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DataAccess.Mapping
{
    public class LocacaoMap : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.ToTable("Locacao");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.DiaLocado)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(l => l.DiaPrazo)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(l => l.DiaDevolucao)
                .HasColumnType("datetime");

            builder.Property(l => l.EstaAtrasado)
                .HasColumnType("boolean");

            builder.HasOne(l => l.Estudante)
                .WithMany(e => e.Locacoes)
                .HasForeignKey(l => l.EstudanteId);

            builder.HasOne(l => l.Volume)
                .WithMany()
                .HasForeignKey(l => l.VolumeId)
                .IsRequired();

            //builder.HasData(GetLocacoes());
        }

        private List<Locacao> GetLocacoes()
        {
            return new List<Locacao>()
            {
                new Locacao()
                {
                    Id = 1,
                    DiaLocado = DateTime.Now,
                    DiaPrazo = DateTime.Now.AddDays(7),
                    EstaAtrasado = false,
                    EstudanteId = 4,
                    VolumeId = 1,
                }
            };
        }
    }
}
