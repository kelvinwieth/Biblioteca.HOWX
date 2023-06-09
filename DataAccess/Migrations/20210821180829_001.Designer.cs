﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(BibliotecaContext))]
    [Migration("20210821180829_001")]
    partial class _001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Domain.Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Autor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Machado de Assis"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Cleitin"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Joana Martin"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Sun Tzu"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "William Shakespeare"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Maicon Hawking"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Joaquim José da Silva Xavier"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Wellington Profeta"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Neymar Júnior"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Lincolm"
                        });
                });

            modelBuilder.Entity("Domain.Models.Estudante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("EstaHabilitado")
                        .HasColumnType("boolean");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("NomeDoCurso")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Estudante");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "jose@univali.com",
                            EstaHabilitado = true,
                            Matricula = "32456789544567",
                            Nome = "José Silva",
                            NomeDoCurso = "Análise e Desenvolvimento de Sistemas"
                        },
                        new
                        {
                            Id = 2,
                            Email = "maria@univali.com",
                            EstaHabilitado = true,
                            Matricula = "8735983759873",
                            Nome = "Maria Joaquina",
                            NomeDoCurso = "Nutrição"
                        });
                });

            modelBuilder.Entity("Domain.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Fantasia"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Filosofia"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Romance"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "História"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Biografia"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Fantasia Científica"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Suspense"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Novelas de Cavalaria"
                        });
                });

            modelBuilder.Entity("Domain.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GeneroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Idioma")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(300)");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Livro");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AutorId = 2,
                            GeneroId = 5,
                            Idioma = "Português",
                            Titulo = "As Aventuras de Cleitin"
                        },
                        new
                        {
                            Id = 2,
                            AutorId = 1,
                            GeneroId = 3,
                            Idioma = "Português",
                            Titulo = "Dom Casmurro"
                        },
                        new
                        {
                            Id = 3,
                            AutorId = 4,
                            GeneroId = 2,
                            Idioma = "Português",
                            Titulo = "A Arte da Guerra"
                        },
                        new
                        {
                            Id = 4,
                            AutorId = 6,
                            GeneroId = 5,
                            Idioma = "Português",
                            Titulo = "A Teoria de Tudo"
                        },
                        new
                        {
                            Id = 5,
                            AutorId = 5,
                            GeneroId = 3,
                            Idioma = "Português",
                            Titulo = "Hamlet"
                        },
                        new
                        {
                            Id = 6,
                            AutorId = 7,
                            GeneroId = 4,
                            Idioma = "Português",
                            Titulo = "A História do Brasil"
                        },
                        new
                        {
                            Id = 7,
                            AutorId = 8,
                            GeneroId = 7,
                            Idioma = "Português",
                            Titulo = "A Profecia Profetizada"
                        },
                        new
                        {
                            Id = 8,
                            AutorId = 10,
                            GeneroId = 6,
                            Idioma = "Português",
                            Titulo = "Era uma Vez"
                        },
                        new
                        {
                            Id = 9,
                            AutorId = 9,
                            GeneroId = 1,
                            Idioma = "Português",
                            Titulo = "Como Fazer Mil Embaixadinhas"
                        },
                        new
                        {
                            Id = 10,
                            AutorId = 1,
                            GeneroId = 3,
                            Idioma = "Português",
                            Titulo = "Memórias Póstumas de Brás Cubas"
                        });
                });

            modelBuilder.Entity("Domain.Models.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DiaDevolucao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DiaLocado")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DiaPrazo")
                        .HasColumnType("datetime");

                    b.Property<bool>("EstaAtrasado")
                        .HasColumnType("boolean");

                    b.Property<int>("EstudanteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VolumeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EstudanteId");

                    b.HasIndex("VolumeId");

                    b.ToTable("Locacao");
                });

            modelBuilder.Entity("Domain.Models.Volume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EstaDisponivel")
                        .HasColumnType("boolean");

                    b.Property<int>("LivroId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.ToTable("Volume");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstaDisponivel = true,
                            LivroId = 1
                        },
                        new
                        {
                            Id = 2,
                            EstaDisponivel = true,
                            LivroId = 2
                        },
                        new
                        {
                            Id = 3,
                            EstaDisponivel = true,
                            LivroId = 3
                        },
                        new
                        {
                            Id = 4,
                            EstaDisponivel = true,
                            LivroId = 4
                        },
                        new
                        {
                            Id = 5,
                            EstaDisponivel = true,
                            LivroId = 5
                        },
                        new
                        {
                            Id = 6,
                            EstaDisponivel = true,
                            LivroId = 6
                        },
                        new
                        {
                            Id = 7,
                            EstaDisponivel = true,
                            LivroId = 7
                        },
                        new
                        {
                            Id = 8,
                            EstaDisponivel = true,
                            LivroId = 4
                        },
                        new
                        {
                            Id = 9,
                            EstaDisponivel = true,
                            LivroId = 4
                        },
                        new
                        {
                            Id = 10,
                            EstaDisponivel = true,
                            LivroId = 7
                        },
                        new
                        {
                            Id = 11,
                            EstaDisponivel = true,
                            LivroId = 7
                        },
                        new
                        {
                            Id = 12,
                            EstaDisponivel = true,
                            LivroId = 8
                        },
                        new
                        {
                            Id = 13,
                            EstaDisponivel = true,
                            LivroId = 8
                        },
                        new
                        {
                            Id = 14,
                            EstaDisponivel = true,
                            LivroId = 9
                        },
                        new
                        {
                            Id = 15,
                            EstaDisponivel = true,
                            LivroId = 9
                        },
                        new
                        {
                            Id = 16,
                            EstaDisponivel = true,
                            LivroId = 10
                        },
                        new
                        {
                            Id = 17,
                            EstaDisponivel = true,
                            LivroId = 10
                        },
                        new
                        {
                            Id = 18,
                            EstaDisponivel = true,
                            LivroId = 10
                        });
                });

            modelBuilder.Entity("Domain.Models.Livro", b =>
                {
                    b.HasOne("Domain.Models.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Genero", "Genero")
                        .WithMany("Livros")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("Domain.Models.Locacao", b =>
                {
                    b.HasOne("Domain.Models.Estudante", "Estudante")
                        .WithMany("Locacoes")
                        .HasForeignKey("EstudanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Volume", "Volume")
                        .WithMany()
                        .HasForeignKey("VolumeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estudante");

                    b.Navigation("Volume");
                });

            modelBuilder.Entity("Domain.Models.Volume", b =>
                {
                    b.HasOne("Domain.Models.Livro", "Livro")
                        .WithMany("Volumes")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("Domain.Models.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("Domain.Models.Estudante", b =>
                {
                    b.Navigation("Locacoes");
                });

            modelBuilder.Entity("Domain.Models.Genero", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("Domain.Models.Livro", b =>
                {
                    b.Navigation("Volumes");
                });
#pragma warning restore 612, 618
        }
    }
}
