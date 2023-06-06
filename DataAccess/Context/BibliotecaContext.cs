using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.Context
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\SQLiteStudio\BibliotecaHOW3.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Volume> Volumes { get; set; }
    }
}
