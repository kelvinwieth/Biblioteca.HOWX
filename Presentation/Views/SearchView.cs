using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class SearchView : UserControl
    {
        private readonly FormBase _formBase;

        public SearchView(FormBase formBase)
        {
            _formBase = formBase;

            InitializeComponent();
            SetTabelas();
        }

        private void SetTabelas()
        {
            var volumesRestantes = _formBase.ResultadoPesquisaVolumes;

            while (volumesRestantes.Count > 0)
            {
                var volumesNaLinha = volumesRestantes.Take(3);
                var id = volumesNaLinha.First().Id;

                var tableLinha = GetTableVolumesRow(id);

                foreach(var volume in volumesNaLinha)
                {
                    var panelVolume = GetPopulatedVolumePanel(volume);
                    tableLinha.Controls.Add(panelVolume);
                }

                panelRowsHolder.Controls.Add(tableLinha);
                volumesRestantes.RemoveRange(0, volumesNaLinha.Count());
            }
        }

        private TableLayoutPanel GetTableVolumesRow(int contador)
        {
            var table = new TableLayoutPanel();

            table.ColumnCount = 3;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            table.Dock = DockStyle.Top;
            table.Name = "tlpVolumesRow" + contador;
            table.RowCount = 1;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            table.Size = new Size(800, 115);
            table.TabIndex = 0;

            return table;
        }

        private Panel GetPopulatedVolumePanel(Volume volume)
        {
            var panelVolume = GetPanelVolume(volume.Id);
            var pbFotoLivro = GetPictureBoxFotoLivro(volume.Id, volume.Livro.FotoUrl);

            var panelVolumeInfos = GetPanelVolumeInfos(volume.Id);
            var lblTituloLivro = GetLabelTituloLivro(volume.Id, volume.Livro.Titulo);
            var lblNomeAutorLivro = GetLabelNomeAutor(volume.Id, volume.Livro.Autor.Nome);
            var lblStatus = GetLabelStatus(volume.Id, volume.EstaDisponivel);

            SetClickEventOnControl(lblTituloLivro, volume);
            SetClickEventOnControl(lblNomeAutorLivro, volume);
            SetClickEventOnControl(lblStatus, volume);
            SetClickEventOnControl(pbFotoLivro, volume);

            panelVolume.Controls.Add(pbFotoLivro);
            panelVolume.Controls.Add(panelVolumeInfos);

            panelVolumeInfos.Controls.Add(lblStatus);
            panelVolumeInfos.Controls.Add(lblNomeAutorLivro);
            panelVolumeInfos.Controls.Add(lblTituloLivro);

            return panelVolume;
        }

        private Panel GetPanelVolume(int id)
        {
            var panelVolume = new Panel();

            panelVolume.Dock = DockStyle.Fill;
            panelVolume.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            panelVolume.Name = "panelVolume" + id;
            panelVolume.Padding = new Padding(5);
            panelVolume.TabIndex = 4;


            return panelVolume;
        }

        private PictureBox GetPictureBoxFotoLivro(int id, string fotoUrl)
        {
            var pbFotoLivro = new PictureBox();

            pbFotoLivro.Dock = DockStyle.Left;
            pbFotoLivro.InitialImage = Properties.Resources.loading;
            pbFotoLivro.Name = "pbFotoLivro" + id;
            pbFotoLivro.Size = new Size(77, 99);
            pbFotoLivro.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoLivro.TabIndex = 0;
            pbFotoLivro.TabStop = false;

            try
            {
                pbFotoLivro.LoadAsync(fotoUrl);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar imagem.\nUrl: " + fotoUrl);
            }

            return pbFotoLivro;
        }

        private Panel GetPanelVolumeInfos(int id)
        {
            var panelVolumeInfos = new Panel();

            panelVolumeInfos.Dock = DockStyle.Right;
            panelVolumeInfos.Name = "panelVolumeInfos" + id;
            panelVolumeInfos.Padding = new Padding(30, 0, 0, 0);
            panelVolumeInfos.TabIndex = 1;

            return panelVolumeInfos;
        }

        private Label GetLabelTituloLivro(int id, string tituloLivro)
        {
            var lblTituloLivro = new Label();

            lblTituloLivro.Dock = DockStyle.Top;
            lblTituloLivro.Name = "lblTituloLivro" + id;
            lblTituloLivro.Size = new Size(163, 28);
            lblTituloLivro.TabIndex = 0;
            lblTituloLivro.Text = tituloLivro;
            lblTituloLivro.TextAlign = ContentAlignment.MiddleLeft;

            return lblTituloLivro;
        }

        private Label GetLabelNomeAutor(int id, string nomeAutor)
        {
            var lblNomeAutor = new Label();

            lblNomeAutor.Dock = DockStyle.Top;
            lblNomeAutor.Name = "lblNomeAutorLivro" + id;
            lblNomeAutor.Size = new Size(163, 28);
            lblNomeAutor.TabIndex = 1;
            lblNomeAutor.Text = nomeAutor;
            lblNomeAutor.TextAlign = ContentAlignment.MiddleLeft;

            return lblNomeAutor;
        }

        private Label GetLabelStatus(int id, bool disponibilidade)
        {
            var lblStatus = new Label();
            var colorLabel = GetLabelStatusColor(disponibilidade);

            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = colorLabel;
            lblStatus.Name = "lblStatus" + id;
            lblStatus.TabIndex = 2;
            lblStatus.Text = GetStringDisponibilidade(disponibilidade);
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;

            return lblStatus;
        }

        private Color GetLabelStatusColor(bool disponibilidade)
        {
            var color = new Color();

            color = disponibilidade ? Color.Green : Color.DarkRed;

            return color;
        }

        private string GetStringDisponibilidade(bool disponibilidade)
        {
            return disponibilidade ? "Disponivel" : "Indisponivel";
        }

        private void SetClickEventOnControl(Control control, Volume volume)
        {
            control.Click += (s, e) => _formBase.VolumeSelecionado = volume;
        }
    }
}
