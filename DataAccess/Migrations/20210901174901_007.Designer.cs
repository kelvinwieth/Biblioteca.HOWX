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
    [Migration("20210901174901_007")]
    partial class _007
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
                            Nome = "George Orwell"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Victor Hugo"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Platão"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Friedrich Nietzsche"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Jane Austen"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Laurentino Gomes"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Sun Tzu"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Christopher Hilton"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Pierre Grimal"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "William Gibson"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Stephen King"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Patrick Rothfuss"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "J. K. Rowling"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "William Peter Blatty"
                        },
                        new
                        {
                            Id = 15,
                            Nome = "Josh Malerman"
                        },
                        new
                        {
                            Id = 16,
                            Nome = "Luis Felipe Pondé"
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

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(4)");

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
                            NomeDoCurso = "Análise e Desenvolvimento de Sistemas",
                            Senha = "1234"
                        },
                        new
                        {
                            Id = 2,
                            Email = "maria@univali.com",
                            EstaHabilitado = true,
                            Matricula = "8735983759873",
                            Nome = "Maria Joaquina",
                            NomeDoCurso = "Nutrição",
                            Senha = "2345"
                        },
                        new
                        {
                            Id = 3,
                            Email = "luis@univali.com",
                            EstaHabilitado = true,
                            Matricula = "4946137609812",
                            Nome = "Luis Oliveira",
                            NomeDoCurso = "Engenharia Mecânica",
                            Senha = "3456"
                        },
                        new
                        {
                            Id = 4,
                            Email = "loretz@univali.com",
                            EstaHabilitado = true,
                            Matricula = "6661235786664",
                            Nome = "Lindomar Pinto",
                            NomeDoCurso = "Artes Visuais",
                            Senha = "4567"
                        },
                        new
                        {
                            Id = 5,
                            Email = "suce@univali.com",
                            EstaHabilitado = true,
                            Matricula = "9995836462424",
                            Nome = "Getulio Silva",
                            NomeDoCurso = "Biomedicina",
                            Senha = "5678"
                        },
                        new
                        {
                            Id = 6,
                            Email = "Larissa@univali.com",
                            EstaHabilitado = true,
                            Matricula = "6661235786664",
                            Nome = "Larissa da Souza Santos",
                            NomeDoCurso = "Design de Jogos e Entretenimento Digital",
                            Senha = "6789"
                        },
                        new
                        {
                            Id = 7,
                            Email = "LeandroPintarelli@univali.com",
                            EstaHabilitado = true,
                            Matricula = "2158621864152",
                            Nome = "Leandro Pintarelli da Souza",
                            NomeDoCurso = "Estética",
                            Senha = "7890"
                        },
                        new
                        {
                            Id = 8,
                            Email = "Peter@Univali.com",
                            EstaHabilitado = true,
                            Matricula = "1318671238971",
                            Nome = "Peter Santos",
                            NomeDoCurso = "Gestão Pública",
                            Senha = "0369"
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
                            Nome = "Drama"
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
                            Nome = "Ficção Científica"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Suspense"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Aventura"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Terror"
                        });
                });

            modelBuilder.Entity("Domain.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FotoUrl")
                        .HasColumnType("varchar(300)");

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
                            AutorId = 1,
                            GeneroId = 1,
                            Idioma = "Português",
                            Titulo = "A revolução dos bichos"
                        },
                        new
                        {
                            Id = 2,
                            AutorId = 2,
                            GeneroId = 1,
                            Idioma = "Português",
                            Titulo = "Os Miseráveis"
                        },
                        new
                        {
                            Id = 3,
                            AutorId = 3,
                            GeneroId = 2,
                            Idioma = "Português",
                            Titulo = "A República"
                        },
                        new
                        {
                            Id = 4,
                            AutorId = 4,
                            GeneroId = 2,
                            Idioma = "Português",
                            Titulo = "Além do Bem e do Mal"
                        },
                        new
                        {
                            Id = 5,
                            AutorId = 5,
                            GeneroId = 3,
                            Idioma = "Português",
                            Titulo = "Orgulho e Preconceito"
                        },
                        new
                        {
                            Id = 6,
                            AutorId = 5,
                            GeneroId = 3,
                            Idioma = "Português",
                            Titulo = "Northanger Abbey"
                        },
                        new
                        {
                            Id = 7,
                            AutorId = 6,
                            GeneroId = 4,
                            Idioma = "Português",
                            Titulo = "1822"
                        },
                        new
                        {
                            Id = 8,
                            AutorId = 7,
                            GeneroId = 4,
                            Idioma = "Português",
                            Titulo = "A Arte da Guerra"
                        },
                        new
                        {
                            Id = 9,
                            AutorId = 8,
                            GeneroId = 5,
                            Idioma = "Português",
                            Titulo = "Ayrton Senna: Uma Lenda a Toda Velocidade"
                        },
                        new
                        {
                            Id = 10,
                            AutorId = 9,
                            GeneroId = 5,
                            Idioma = "Português",
                            Titulo = "Marco Aurélio: O imperador filósofo "
                        },
                        new
                        {
                            Id = 11,
                            AutorId = 10,
                            GeneroId = 6,
                            Idioma = "Português",
                            Titulo = "Neuromancer"
                        },
                        new
                        {
                            Id = 12,
                            AutorId = 1,
                            GeneroId = 6,
                            Idioma = "Português",
                            Titulo = "1984"
                        },
                        new
                        {
                            Id = 13,
                            AutorId = 11,
                            GeneroId = 7,
                            Idioma = "Português",
                            Titulo = "It - A Coisa"
                        },
                        new
                        {
                            Id = 14,
                            AutorId = 11,
                            GeneroId = 7,
                            Idioma = "Português",
                            Titulo = "The Outsider"
                        },
                        new
                        {
                            Id = 15,
                            AutorId = 12,
                            GeneroId = 8,
                            Idioma = "Português",
                            Titulo = "O Nome do Vento"
                        },
                        new
                        {
                            Id = 16,
                            AutorId = 13,
                            GeneroId = 8,
                            Idioma = "Português",
                            Titulo = "Harry Potter e a Pedra Filosofal"
                        },
                        new
                        {
                            Id = 17,
                            AutorId = 14,
                            GeneroId = 9,
                            Idioma = "Português",
                            Titulo = "O Exorcista"
                        },
                        new
                        {
                            Id = 18,
                            AutorId = 15,
                            GeneroId = 9,
                            Idioma = "Português",
                            Titulo = "Caixa de Pássaros"
                        },
                        new
                        {
                            Id = 19,
                            AutorId = 6,
                            GeneroId = 4,
                            Idioma = "Português",
                            Titulo = "1889"
                        },
                        new
                        {
                            Id = 20,
                            AutorId = 16,
                            GeneroId = 2,
                            Idioma = "Português",
                            Titulo = "Filosofia para corajosos"
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiaLocado = new DateTime(2021, 9, 1, 14, 49, 0, 179, DateTimeKind.Local).AddTicks(954),
                            DiaPrazo = new DateTime(2021, 9, 8, 14, 49, 0, 180, DateTimeKind.Local).AddTicks(8232),
                            EstaAtrasado = false,
                            EstudanteId = 4,
                            VolumeId = 1
                        });
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
                            LivroId = 1
                        },
                        new
                        {
                            Id = 3,
                            EstaDisponivel = true,
                            LivroId = 1
                        },
                        new
                        {
                            Id = 4,
                            EstaDisponivel = true,
                            LivroId = 2
                        },
                        new
                        {
                            Id = 5,
                            EstaDisponivel = true,
                            LivroId = 2
                        },
                        new
                        {
                            Id = 6,
                            EstaDisponivel = true,
                            LivroId = 2
                        },
                        new
                        {
                            Id = 7,
                            EstaDisponivel = true,
                            LivroId = 3
                        },
                        new
                        {
                            Id = 8,
                            EstaDisponivel = true,
                            LivroId = 3
                        },
                        new
                        {
                            Id = 9,
                            EstaDisponivel = true,
                            LivroId = 3
                        },
                        new
                        {
                            Id = 10,
                            EstaDisponivel = true,
                            LivroId = 4
                        },
                        new
                        {
                            Id = 11,
                            EstaDisponivel = true,
                            LivroId = 4
                        },
                        new
                        {
                            Id = 12,
                            EstaDisponivel = true,
                            LivroId = 4
                        },
                        new
                        {
                            Id = 13,
                            EstaDisponivel = true,
                            LivroId = 5
                        },
                        new
                        {
                            Id = 14,
                            EstaDisponivel = true,
                            LivroId = 5
                        },
                        new
                        {
                            Id = 15,
                            EstaDisponivel = true,
                            LivroId = 5
                        },
                        new
                        {
                            Id = 16,
                            EstaDisponivel = true,
                            LivroId = 6
                        },
                        new
                        {
                            Id = 17,
                            EstaDisponivel = true,
                            LivroId = 6
                        },
                        new
                        {
                            Id = 18,
                            EstaDisponivel = true,
                            LivroId = 6
                        },
                        new
                        {
                            Id = 19,
                            EstaDisponivel = true,
                            LivroId = 7
                        },
                        new
                        {
                            Id = 20,
                            EstaDisponivel = true,
                            LivroId = 7
                        },
                        new
                        {
                            Id = 21,
                            EstaDisponivel = true,
                            LivroId = 7
                        },
                        new
                        {
                            Id = 22,
                            EstaDisponivel = true,
                            LivroId = 8
                        },
                        new
                        {
                            Id = 23,
                            EstaDisponivel = true,
                            LivroId = 8
                        },
                        new
                        {
                            Id = 24,
                            EstaDisponivel = true,
                            LivroId = 8
                        },
                        new
                        {
                            Id = 25,
                            EstaDisponivel = true,
                            LivroId = 9
                        },
                        new
                        {
                            Id = 26,
                            EstaDisponivel = true,
                            LivroId = 9
                        },
                        new
                        {
                            Id = 27,
                            EstaDisponivel = true,
                            LivroId = 9
                        },
                        new
                        {
                            Id = 28,
                            EstaDisponivel = true,
                            LivroId = 10
                        },
                        new
                        {
                            Id = 29,
                            EstaDisponivel = true,
                            LivroId = 10
                        },
                        new
                        {
                            Id = 30,
                            EstaDisponivel = true,
                            LivroId = 10
                        },
                        new
                        {
                            Id = 31,
                            EstaDisponivel = true,
                            LivroId = 11
                        },
                        new
                        {
                            Id = 32,
                            EstaDisponivel = true,
                            LivroId = 11
                        },
                        new
                        {
                            Id = 33,
                            EstaDisponivel = true,
                            LivroId = 11
                        },
                        new
                        {
                            Id = 34,
                            EstaDisponivel = true,
                            LivroId = 12
                        },
                        new
                        {
                            Id = 35,
                            EstaDisponivel = true,
                            LivroId = 12
                        },
                        new
                        {
                            Id = 36,
                            EstaDisponivel = true,
                            LivroId = 12
                        },
                        new
                        {
                            Id = 37,
                            EstaDisponivel = true,
                            LivroId = 13
                        },
                        new
                        {
                            Id = 38,
                            EstaDisponivel = true,
                            LivroId = 13
                        },
                        new
                        {
                            Id = 39,
                            EstaDisponivel = true,
                            LivroId = 13
                        },
                        new
                        {
                            Id = 40,
                            EstaDisponivel = true,
                            LivroId = 14
                        },
                        new
                        {
                            Id = 41,
                            EstaDisponivel = true,
                            LivroId = 14
                        },
                        new
                        {
                            Id = 42,
                            EstaDisponivel = true,
                            LivroId = 14
                        },
                        new
                        {
                            Id = 43,
                            EstaDisponivel = true,
                            LivroId = 15
                        },
                        new
                        {
                            Id = 44,
                            EstaDisponivel = true,
                            LivroId = 15
                        },
                        new
                        {
                            Id = 45,
                            EstaDisponivel = true,
                            LivroId = 15
                        },
                        new
                        {
                            Id = 46,
                            EstaDisponivel = true,
                            LivroId = 16
                        },
                        new
                        {
                            Id = 47,
                            EstaDisponivel = true,
                            LivroId = 16
                        },
                        new
                        {
                            Id = 48,
                            EstaDisponivel = true,
                            LivroId = 16
                        },
                        new
                        {
                            Id = 49,
                            EstaDisponivel = true,
                            LivroId = 17
                        },
                        new
                        {
                            Id = 50,
                            EstaDisponivel = true,
                            LivroId = 17
                        },
                        new
                        {
                            Id = 51,
                            EstaDisponivel = true,
                            LivroId = 17
                        },
                        new
                        {
                            Id = 52,
                            EstaDisponivel = true,
                            LivroId = 18
                        },
                        new
                        {
                            Id = 53,
                            EstaDisponivel = true,
                            LivroId = 18
                        },
                        new
                        {
                            Id = 54,
                            EstaDisponivel = true,
                            LivroId = 18
                        },
                        new
                        {
                            Id = 55,
                            EstaDisponivel = true,
                            LivroId = 19
                        },
                        new
                        {
                            Id = 56,
                            EstaDisponivel = true,
                            LivroId = 19
                        },
                        new
                        {
                            Id = 57,
                            EstaDisponivel = true,
                            LivroId = 19
                        },
                        new
                        {
                            Id = 58,
                            EstaDisponivel = true,
                            LivroId = 20
                        },
                        new
                        {
                            Id = 59,
                            EstaDisponivel = true,
                            LivroId = 20
                        },
                        new
                        {
                            Id = 60,
                            EstaDisponivel = true,
                            LivroId = 20
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
