using Domain.Models;
using Presentation.Presenters;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class FormBase : Form, Interfaces.FormBase
    {
        private BasePresenter presenter;
        private Estudante estudanteLogado;
        private List<Volume> resultadoPesquisaVolumes;
        private Volume volumeSelecionado;

        public FormBase()
        {
            presenter = new BasePresenter(this);

            InitializeComponent();

            SetView(new LoginView(this));
        }

        public Estudante EstudanteLogado
        {
            get => estudanteLogado;
            set
            {
                if (value == null)
                {
                    SetView(new LoginView(this));
                    return;
                }

                estudanteLogado = value;
                AdicionarNavbar();
                SetView(new HomeView(this));
            }
        }

        public List<Volume> ResultadoPesquisaVolumes
        {
            get => resultadoPesquisaVolumes;
            set
            {
                resultadoPesquisaVolumes = value;
                SetView(new SearchView(this));
            }
        }
        public Volume VolumeSelecionado
        {
            get => volumeSelecionado;
            set
            {
                if (value == null)
                {
                    SetView(new HomeView(this));
                    return;
                }

                volumeSelecionado = value;

                SetView(new LivroView(this));
            }
        }

        public async Task Login(string matricula, string senha)
        {
            await presenter.Login(matricula, senha);
        }

        public async Task PesquisarVolumes(string filtro)
        {
            await presenter.PesquisarVolumes(filtro);
        }

        public void SelecionarVolume(Volume volume)
        {
            presenter.SelecionarVolume(volume);
        }

        public async Task AlugarVolume(Volume volume)
        {
            await presenter.AlugarVolume(volume);
        }

        public async Task DevolverVolume(Volume volume)
        {
            await presenter.DevolverVolume(volume);
        }

        public async Task AtualizarEstudanteLogado()
        {
            await presenter.AtualizarEstudanteLogado();
        }

        public void Logout()
        {
            presenter.Logout();
        }

        private void SetView(UserControl view)
        {
            if (EhLoginView(view))
            {
                DesabilitarNavbar();
            }
            else
            {
                HabilitarNavbar();
            }

            panelViewHolder.Controls.Clear();
            panelViewHolder.Controls.Add(view);
        }

        private bool EhLoginView(UserControl control)
        {
            bool ehLoginView = control.GetType() == typeof(LoginView);

            return ehLoginView;
        }

        private void AdicionarNavbar()
        {
            var navbar = new NavbarControl(this);
            panelNavbarHolder.Controls.Add(navbar);
        }

        private void DesabilitarNavbar()
        {
            panelNavbarHolder.Visible = false;
        }

        private void HabilitarNavbar()
        {
            panelNavbarHolder.Visible = true;
        }
    }
}
