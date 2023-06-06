using System;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class LoginView : UserControl
    {
        private Interfaces.FormBase _baseView;

        public LoginView(Interfaces.FormBase baseView)
        {
            _baseView = baseView;

            InitializeComponent();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            var matricula = tbMatricula.Text;
            var senha = tbSenha.Text;

            try
            {
                await _baseView.Login(matricula, senha);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
