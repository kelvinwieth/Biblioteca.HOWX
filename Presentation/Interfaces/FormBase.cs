using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface FormBase
    {
        public Estudante EstudanteLogado { get; set; }
        public List<Volume> ResultadoPesquisaVolumes { get; set; }
        public Volume VolumeSelecionado { get; set; }

        Task Login(string matricula, string senha);
        Task PesquisarVolumes(string filtro);
        void SelecionarVolume(Volume volume);
        Task AlugarVolume(Volume volume);
        Task DevolverVolume(Volume volume);
        void Logout();
    }
}
