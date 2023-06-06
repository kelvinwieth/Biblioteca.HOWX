using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Models
{
    public class Estudante
    {
        public Estudante() { }

        public Estudante(string matricula, string nome, string email, string nomeDoCurso)
        {
            Matricula = matricula;
            Nome = nome;
            Email = email;
            NomeDoCurso = nomeDoCurso;
        }

        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string NomeDoCurso { get; set; }
        public string Senha { get; set; }
        public bool EstaHabilitado { get; set; }
        public List<Locacao> Locacoes { get; set; }

        public void AlugarVolume(Volume volume)
        {
            var quantidadeLocacoesAbertas = GetQuantidadeLocacoesAbertas();

            if (quantidadeLocacoesAbertas >= 3)
                throw new ArgumentException("Você já possui o máximo de 03 locações abertas. Devolva um livro para continuar.");

            var locacao = new Locacao(this, volume);
            Locacoes.Add(locacao);
        }

        public void DevolverVolume(Volume volume)
        {
            var locacaoComVolume = Locacoes.Where(l => l.VolumeId == volume.Id && l.DiaDevolucao == null).FirstOrDefault();

            if (locacaoComVolume == default)
                throw new ArgumentException("Este livro nao foi alugado por este estudante.");

            locacaoComVolume.Finalizar();
        }

        public void AtualizarSituacao()
        {
            int locacoesAbertas = GetQuantidadeLocacoesAbertas();

            if (locacoesAbertas >= 3)
            {
                EstaHabilitado = false;
            }
        }

        public List<Volume> GetVolumesLocadosEmAberto()
        {
            return Locacoes
                .Where(l => l.DiaDevolucao == null)
                .Select(l => l.Volume)
                .ToList();
        }

        public List<Locacao> GetLocacoesEmAberto()
        {
            return Locacoes
                .Where(l => l.DiaDevolucao == null)
                .ToList();
        }

        public int GetQuantidadeLocacoesAbertas()
        {
            return Locacoes.Where(l => l.DiaDevolucao == null).Count();
        }

        public int GetQuantidadeLocacoesAtrasadas()
        {
            return Locacoes.Where(locacao => locacao.EstaAtrasado == true).Count();
        }
    }
}
