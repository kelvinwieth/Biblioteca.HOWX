using System.Collections.Generic;

namespace Domain.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Idioma { get; set; }
        public string FotoUrl { get; set; }
        public string Descricao { get; set; }
        public int AutorId { get; set; }
        public int GeneroId { get; set; }

        public List<Volume> Volumes { get; set; }
        public Genero Genero { get; set; }
        public Autor Autor { get; set; }

        public void AddVolumes(int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                Volumes.Add(new Volume(this));
            }
        }
    }
}
