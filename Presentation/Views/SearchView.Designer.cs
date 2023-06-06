
namespace Presentation.Views
{
    partial class SearchView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRowsHolder = new System.Windows.Forms.Panel();
            this.tlpVolumesRow = new System.Windows.Forms.TableLayoutPanel();
            this.panelVolume = new System.Windows.Forms.Panel();
            this.panelVolumeInfos = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNomeAutorLivro = new System.Windows.Forms.Label();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.pbFotoLivro = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelRowsHolder.SuspendLayout();
            this.tlpVolumesRow.SuspendLayout();
            this.panelVolume.SuspendLayout();
            this.panelVolumeInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(800, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultados da pesquisa:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRowsHolder
            // 
            this.panelRowsHolder.AutoScroll = true;
            this.panelRowsHolder.Controls.Add(this.tlpVolumesRow);
            this.panelRowsHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRowsHolder.Location = new System.Drawing.Point(0, 77);
            this.panelRowsHolder.Name = "panelRowsHolder";
            this.panelRowsHolder.Size = new System.Drawing.Size(800, 373);
            this.panelRowsHolder.TabIndex = 1;
            // 
            // tlpVolumesRow
            // 
            this.tlpVolumesRow.ColumnCount = 3;
            this.tlpVolumesRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpVolumesRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpVolumesRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpVolumesRow.Controls.Add(this.panelVolume, 0, 0);
            this.tlpVolumesRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpVolumesRow.Location = new System.Drawing.Point(0, 0);
            this.tlpVolumesRow.Name = "tlpVolumesRow";
            this.tlpVolumesRow.RowCount = 1;
            this.tlpVolumesRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVolumesRow.Size = new System.Drawing.Size(800, 115);
            this.tlpVolumesRow.TabIndex = 0;
            this.tlpVolumesRow.Visible = false;
            // 
            // panelVolume
            // 
            this.panelVolume.Controls.Add(this.panelVolumeInfos);
            this.panelVolume.Controls.Add(this.pbFotoLivro);
            this.panelVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVolume.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelVolume.Location = new System.Drawing.Point(3, 3);
            this.panelVolume.Name = "panelVolume";
            this.panelVolume.Padding = new System.Windows.Forms.Padding(5);
            this.panelVolume.Size = new System.Drawing.Size(260, 109);
            this.panelVolume.TabIndex = 4;
            // 
            // panelVolumeInfos
            // 
            this.panelVolumeInfos.Controls.Add(this.lblStatus);
            this.panelVolumeInfos.Controls.Add(this.lblNomeAutorLivro);
            this.panelVolumeInfos.Controls.Add(this.lblTituloLivro);
            this.panelVolumeInfos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelVolumeInfos.Location = new System.Drawing.Point(82, 5);
            this.panelVolumeInfos.Name = "panelVolumeInfos";
            this.panelVolumeInfos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelVolumeInfos.Size = new System.Drawing.Size(173, 99);
            this.panelVolumeInfos.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(10, 56);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(163, 43);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Disponivel";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomeAutorLivro
            // 
            this.lblNomeAutorLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNomeAutorLivro.Location = new System.Drawing.Point(10, 28);
            this.lblNomeAutorLivro.Name = "lblNomeAutorLivro";
            this.lblNomeAutorLivro.Size = new System.Drawing.Size(163, 28);
            this.lblNomeAutorLivro.TabIndex = 1;
            this.lblNomeAutorLivro.Text = "Nome do autor";
            this.lblNomeAutorLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTituloLivro.Location = new System.Drawing.Point(10, 0);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(163, 28);
            this.lblTituloLivro.TabIndex = 0;
            this.lblTituloLivro.Text = "Nome do livro";
            this.lblTituloLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbFotoLivro
            // 
            this.pbFotoLivro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFotoLivro.InitialImage = global::Presentation.Properties.Resources.loading;
            this.pbFotoLivro.Location = new System.Drawing.Point(5, 5);
            this.pbFotoLivro.Name = "pbFotoLivro";
            this.pbFotoLivro.Size = new System.Drawing.Size(77, 99);
            this.pbFotoLivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoLivro.TabIndex = 0;
            this.pbFotoLivro.TabStop = false;
            // 
            // SearchView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelRowsHolder);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SearchView";
            this.Size = new System.Drawing.Size(800, 450);
            this.panel1.ResumeLayout(false);
            this.panelRowsHolder.ResumeLayout(false);
            this.tlpVolumesRow.ResumeLayout(false);
            this.panelVolume.ResumeLayout(false);
            this.panelVolumeInfos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRowsHolder;
        private System.Windows.Forms.TableLayoutPanel tlpVolumesRow;
        private System.Windows.Forms.Panel panelVolume;
        private System.Windows.Forms.PictureBox pbFotoLivro;
        private System.Windows.Forms.Panel panelVolumeInfos;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNomeAutorLivro;
    }
}
