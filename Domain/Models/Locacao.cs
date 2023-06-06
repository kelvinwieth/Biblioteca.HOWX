using System;

namespace Domain.Models
{
    public class Locacao
    {
        public Locacao() { }

        public Locacao(Estudante estudante, Volume volume)
        {
            if (volume.EstaDisponivel == false)
            {
                throw new ArgumentException("Este livro já está locado.");
            }

            if (estudante.EstaHabilitado == false)
            {
                throw new ArgumentException("Estudante não está habilitado.");
            }

            EstudanteId = estudante.Id;
            Volume = volume;
            DiaLocado = DateTime.Now;
            DiaPrazo = DiaLocado.AddDays(15);

            EstaAtrasado = false;
            Volume.EstaDisponivel = false;
        }

        private bool estaAtrasado;

        public int Id { get; set; }
        public DateTime DiaLocado { get; set; }
        public DateTime DiaPrazo { get; set; }
        public DateTime? DiaDevolucao { get; set; }
        public bool EstaAtrasado
        {
            get
            {
                AtualizarSituacao();
                return estaAtrasado;
            }
            set 
            {
                estaAtrasado = value;
            }
        }

        public int VolumeId { get; set; }
        public int EstudanteId { get; set; }
        public Volume Volume { get; set; }
        public Estudante Estudante { get; private set; }

        public void Finalizar()
        {
            DiaDevolucao = DateTime.Now;
            EstaAtrasado = false;

            Volume.EstaDisponivel = true;
        }

        public void AtualizarSituacao()
        {
            if (DiaDevolucao == null && DateTime.Now > DiaPrazo)
            {
                EstaAtrasado = true;
            }
        }

        public override string ToString()
        {
            return $"{DiaPrazo.ToShortDateString()} - {Volume.Livro.Titulo}";
        }
    }
}
