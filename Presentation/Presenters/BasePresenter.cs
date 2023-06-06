using DataAccess.Context;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Presentation.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class BasePresenter
    {
        private readonly FormBase _baseView;
        private readonly BibliotecaContext _context;

        public BasePresenter(FormBase baseView)
        {
            _baseView = baseView;
            _context = new BibliotecaContext();
        }

        public async Task Login(string matricula, string senha)
        {
            var locacoes = await _context.Locacoes.ToListAsync();

            var estudante = await _context.Estudantes
                .Include(e => e.Locacoes)
                    .ThenInclude(l => l.Volume)
                        .ThenInclude(v => v.Livro)
                .Where(e => e.Matricula == matricula && e.Senha == senha)
                .SingleOrDefaultAsync();

            var volumes = await _context.Volumes.ToListAsync();

            if (estudante == default)
                throw new ArgumentException("Credenciais inválidas.");

            _baseView.EstudanteLogado = estudante;
        }

        public async Task PesquisarVolumes(string filtro)
        {
            var filtroLower = filtro.ToLower();

            var volumes = await _context.Volumes
                .Include(v => v.Livro)
                    .ThenInclude(l => l.Autor)
                .Include(v => v.Livro)
                    .ThenInclude(l => l.Genero)
                .Where(v =>
                    v.Livro.Titulo.ToLower().Contains(filtroLower) ||
                    v.Livro.Autor.Nome.ToLower().Contains(filtroLower) ||
                    v.Livro.Genero.Nome.ToLower().Contains(filtroLower))
                .ToListAsync();

            if (volumes.Count < 1)
                throw new ArgumentException("Não foram encontrados livros com estes critérios.");

            _baseView.ResultadoPesquisaVolumes = volumes;
        }

        public void SelecionarVolume(Volume volume)
        {
            if (volume == null)
                throw new ArgumentException("Nenhum volume selecionado.");

            _baseView.VolumeSelecionado = volume;
        }

        public async Task AlugarVolume(Volume volume)
        {
            if (volume == null)
                throw new ArgumentException("Nenhum volume selecionado.");

            var estudante = _baseView.EstudanteLogado;

            if (estudante == null)
                throw new ArgumentException("Nenhum estudante logado.");

            estudante.AlugarVolume(volume);
            await _context.SaveChangesAsync();
        }

        public async Task DevolverVolume(Volume volume)
        {
            if (volume == null)
                throw new ArgumentException("Nenhum volume selecionado.");

            var estudante = _baseView.EstudanteLogado;

            if (estudante == null)
                throw new ArgumentException("Nenhum estudante logado.");

            estudante.DevolverVolume(volume);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarEstudanteLogado()
        {
            var estudante = _baseView.EstudanteLogado
                ?? throw new ArgumentException("Nenhum estudante logado.");

            var estudanteAtualizado = await _context.Estudantes
                .Include(e => e.Locacoes)
                    .ThenInclude(l => l.Volume)
                        .ThenInclude(v => v.Livro)
                .Where(e => e.Id == estudante.Id)
                .SingleOrDefaultAsync();

            if (estudante == default)
                throw new ArgumentException("Houve um erro ao atualizar as informações.");

            _baseView.EstudanteLogado = estudanteAtualizado;
        }

        public void Logout()
        {
            _baseView.EstudanteLogado = null;
        }
    }
}
