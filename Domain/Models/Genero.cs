using System.Collections.Generic;

namespace Domain.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
