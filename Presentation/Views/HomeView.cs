using Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class HomeView : UserControl
    {
        private readonly FormBase _formBase;
        private readonly List<Locacao> _locacoesAbertas;

        public HomeView(FormBase formBase)
        {
            _formBase = formBase;
            _locacoesAbertas = _formBase.EstudanteLogado.GetLocacoesEmAberto();

            InitializeComponent();

            SetLabelQuantidadeLocacoes();
            SetPanelLocacoesEmAberto();
            SetTextoDatasLocacoes();
        }

        private void SetPanelLocacoesEmAberto()
        {
            int contador = 1;

            foreach (var locacao in _locacoesAbertas)
            {
                var volume = locacao.Volume;

                var volumePanel = GetVolumePanel(volume, contador);
                volumePanel.Tag = locacao.DiaPrazo.ToShortDateString() + $" - Livro {contador}";

                panelVolumesEmAberto.Controls.Add(volumePanel);
                contador++;
            }
        }

        private void SetTextoDatasLocacoes()
        {
            var textoDatas = GetTextoDatasLocacoes();
            lblDatasLocacoes.Text = string.Join("\n\n", textoDatas);
        }

        private void SetLabelQuantidadeLocacoes()
        {
            var quantidade = _locacoesAbertas.Count;
            lblQuantidadeLocacoes.Text = $"Você possui {quantidade} livros alugados.";
        }

        private Panel GetVolumePanel(Volume volume, int numero)
        {
            var livro = volume.Livro;

            var panelVolume = new Panel();
            var lblNomeLivro = new Label();
            var pbFotoLivro = new PictureBox();

            // 
            // painelLivro
            // 
            panelVolume.Controls.Add(lblNomeLivro);
            panelVolume.Controls.Add(pbFotoLivro);
            panelVolume.Dock = DockStyle.Top;
            panelVolume.Name = $"panelVolume{volume.Id}";
            panelVolume.Size = new Size(396, 100);
            panelVolume.Padding = new Padding(0, 0, 0, 5);
            panelVolume.TabIndex = 0;
            // 
            // lbNomeLivro
            // 
            lblNomeLivro.Dock = DockStyle.Fill;
            lblNomeLivro.Font = new Font("Arial", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeLivro.Name = $"lblNomeLivro{volume.Id}";
            lblNomeLivro.Padding = new Padding(15, 0, 0, 0);
            lblNomeLivro.Size = new Size(319, 100);
            lblNomeLivro.TabIndex = 1;
            lblNomeLivro.Text = $"Livro {numero} - {livro.Titulo}";
            lblNomeLivro.TextAlign = ContentAlignment.MiddleLeft;
            lblNomeLivro.Click += (s, e) => DevolverVolume(volume);
            // 
            // pbLivroFoto
            // 
            pbFotoLivro.Dock = DockStyle.Left;
            pbFotoLivro.Name = $"pbFotoLivro{volume.Id}";
            pbFotoLivro.Size = new Size(77, 100);
            pbFotoLivro.TabIndex = 0;
            pbFotoLivro.TabStop = false;
            pbFotoLivro.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoLivro.InitialImage = Properties.Resources.loading;
            pbFotoLivro.Click += (s, e) => DevolverVolume(volume);
            //

            try
            {
                pbFotoLivro.LoadAsync(livro.FotoUrl);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

            return panelVolume;
        }

        private List<string> GetTextoDatasLocacoes()
        {
            var datasLocacoes = new List<string>();
            var panels = panelVolumesEmAberto.Controls.OfType<Panel>().Skip(1); // Skip 1 pq temos um painel "fake", e se pegar ele retorna null

            foreach (var panel in panels)
            {
                var dataLocacao = panel.Tag as string;
                datasLocacoes.Add(dataLocacao);
            }

            return datasLocacoes;
        }

        private async void DevolverVolume(Volume volume)
        {
            var resposta = MessageBox.Show(
                $"Deseja devolver o livro {volume.Livro.Titulo}?",
                "Confirmação de devolução",
                MessageBoxButtons.YesNoCancel);

            if (resposta == DialogResult.Yes)
            {
                await _formBase.DevolverVolume(volume);
                MessageBox.Show("Devolução realizada com sucesso!");
                await _formBase.AtualizarEstudanteLogado();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que deseja sair?", "Confirmar Logout", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                _formBase.EstudanteLogado = null;
            }
        }
    }
}
