namespace Domain.Models
{
    public class Volume
    {
        public Volume() { }

        public Volume(Livro livro)
        {
            Livro = livro;
        }

        public int Id { get; set; }
        public bool EstaDisponivel { get; set; }
        public int LivroId { get; set; }

        public Livro Livro { get; set; }
    }
}
