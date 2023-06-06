using System.Collections.Generic;

namespace Domain.Models
{
    public class Autor
    {
        public Autor() { }

        public Autor(string nome)
        {
            Nome = nome;
            Livros = new();
        }

        public int Id { get; init; }
        public string Nome { get; set; }

        public List<Livro> Livros { get; private set; }
    }
}
