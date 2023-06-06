using Domain.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class LivroView : UserControl
    {
        private readonly FormBase _formBase;
        private readonly Volume _volume;

        public LivroView(FormBase formBase)
        {
            _formBase = formBase;
            _volume = _formBase.VolumeSelecionado;

            InitializeComponent();

            SetComponentsValues();
        }

        private void SetComponentsValues()
        {
            SetLabelLivroAutorNome(_volume);
            SetLabelLivroTitulo(_volume);
            SetLabelVolumeStatus(_volume);
            SetPictureBoxLivroFoto(_volume);
            SetLabelLivroDescricao(_volume);
        }

        private void SetLabelLivroAutorNome(Volume volume)
        {
            lblLivroAutorNome.Text = volume.Livro.Autor.Nome;
        }

        private void SetLabelLivroTitulo(Volume volume)
        {
            lblLivroTitulo.Text = volume.Livro.Titulo;
        }

        private void SetLabelVolumeStatus(Volume volume)
        {
            lblVolumeStatus.Text = volume.EstaDisponivel ? "Disponível" : "Indisponível";
            lblVolumeStatus.ForeColor = GetLabelStatusColor(volume.EstaDisponivel);
        }

        private Color GetLabelStatusColor(bool disponibilidade)
        {
            return disponibilidade ? Color.Green : Color.DarkRed;
        }

        private void SetLabelLivroDescricao(Volume volume)
        {
            lblLivroDescricao.Text = volume.Livro.Descricao;
        }

        private void SetPictureBoxLivroFoto(Volume volume)
        {
            try
            {
                pbLivroFoto.LoadAsync(volume.Livro.FotoUrl);
            }
            catch (Exception E)
            {
                MessageBox.Show("Não foi possível carregar a imagem. Erro: " + E.Message);
            }
        }

        private async void btnAlugar_Click(object sender, EventArgs e)
        {
            if(_volume.EstaDisponivel == false)
            {
                MessageBox.Show("Este livro está indisponível!");
                return;
            }

            var resposta = MessageBox.Show("Tem certeza que deseja alugar este livro?", "Confirmar locação", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.No)
                return;

            try
            {
                await _formBase.AlugarVolume(_volume);
                MessageBox.Show("Volume alugado com sucesso!");

                _formBase.VolumeSelecionado = null;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            _formBase.VolumeSelecionado = null;
        }
    }
}
