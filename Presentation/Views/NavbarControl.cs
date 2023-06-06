using System;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class NavbarControl : UserControl
    {
        private readonly FormBase _formBase;

        public NavbarControl(FormBase formBase)
        {
            _formBase = formBase;

            InitializeComponent();
            PopularLabelComDadosEstudante();
        }

        private void PopularLabelComDadosEstudante()
        {
            var matriculaComNome = GetMatriculaComNomeEstudante();
            lblRaComNomeEstudante.Text = matriculaComNome;
        }

        private string GetMatriculaComNomeEstudante()
        {
            var estudante = _formBase.EstudanteLogado;
            var raComNomeEstudante = $"{estudante.Matricula} - {estudante.Nome}";
            return raComNomeEstudante;
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var filtro = tbInputPesquisa.Text;
                await _formBase.PesquisarVolumes(filtro);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private async void btnHome_Click(object sender, EventArgs e)
        {
            await _formBase.AtualizarEstudanteLogado();
        }
    }
}
