
namespace Presentation.Views
{
    partial class HomeView
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
            this.panelVolumesEmAberto = new System.Windows.Forms.Panel();
            this.painelLivro = new System.Windows.Forms.Panel();
            this.lbNomeLivro = new System.Windows.Forms.Label();
            this.pbLivroFoto = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantidadeLocacoes = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblDatasLocacoes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelVolumesEmAberto.SuspendLayout();
            this.painelLivro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLivroFoto)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelVolumesEmAberto);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 450);
            this.panel1.TabIndex = 0;
            // 
            // panelVolumesEmAberto
            // 
            this.panelVolumesEmAberto.AutoScroll = true;
            this.panelVolumesEmAberto.Controls.Add(this.painelLivro);
            this.panelVolumesEmAberto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVolumesEmAberto.Location = new System.Drawing.Point(0, 83);
            this.panelVolumesEmAberto.Name = "panelVolumesEmAberto";
            this.panelVolumesEmAberto.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panelVolumesEmAberto.Size = new System.Drawing.Size(411, 367);
            this.panelVolumesEmAberto.TabIndex = 1;
            // 
            // painelLivro
            // 
            this.painelLivro.Controls.Add(this.lbNomeLivro);
            this.painelLivro.Controls.Add(this.pbLivroFoto);
            this.painelLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelLivro.Location = new System.Drawing.Point(15, 0);
            this.painelLivro.Name = "painelLivro";
            this.painelLivro.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.painelLivro.Size = new System.Drawing.Size(396, 100);
            this.painelLivro.TabIndex = 0;
            this.painelLivro.Visible = false;
            // 
            // lbNomeLivro
            // 
            this.lbNomeLivro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNomeLivro.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNomeLivro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNomeLivro.Location = new System.Drawing.Point(77, 0);
            this.lbNomeLivro.Name = "lbNomeLivro";
            this.lbNomeLivro.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbNomeLivro.Size = new System.Drawing.Size(319, 95);
            this.lbNomeLivro.TabIndex = 1;
            this.lbNomeLivro.Text = "Livro 1 - Livro Teste";
            this.lbNomeLivro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbLivroFoto
            // 
            this.pbLivroFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLivroFoto.InitialImage = global::Presentation.Properties.Resources.loading;
            this.pbLivroFoto.Location = new System.Drawing.Point(0, 0);
            this.pbLivroFoto.Name = "pbLivroFoto";
            this.pbLivroFoto.Size = new System.Drawing.Size(77, 95);
            this.pbLivroFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLivroFoto.TabIndex = 0;
            this.pbLivroFoto.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblQuantidadeLocacoes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(411, 83);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clique no livro para iniciar sua devolução.";
            // 
            // lblQuantidadeLocacoes
            // 
            this.lblQuantidadeLocacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuantidadeLocacoes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantidadeLocacoes.Location = new System.Drawing.Point(15, 0);
            this.lblQuantidadeLocacoes.Name = "lblQuantidadeLocacoes";
            this.lblQuantidadeLocacoes.Size = new System.Drawing.Size(396, 36);
            this.lblQuantidadeLocacoes.TabIndex = 0;
            this.lblQuantidadeLocacoes.Text = "Você possui 2 livros alugados:";
            this.lblQuantidadeLocacoes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(411, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 450);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLogout);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(389, 450);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblDatasLocacoes);
            this.panel6.Controls.Add(this.label2);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(159, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 184);
            this.panel6.TabIndex = 0;
            // 
            // lblDatasLocacoes
            // 
            this.lblDatasLocacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatasLocacoes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatasLocacoes.Location = new System.Drawing.Point(0, 55);
            this.lblDatasLocacoes.Name = "lblDatasLocacoes";
            this.lblDatasLocacoes.Size = new System.Drawing.Size(200, 127);
            this.lblDatasLocacoes.TabIndex = 1;
            this.lblDatasLocacoes.Text = "03/02/2021 - Livro 1";
            this.lblDatasLocacoes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data de entrega:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Image = global::Presentation.Properties.Resources.logout32;
            this.btnLogout.Location = new System.Drawing.Point(281, 368);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 67);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(800, 450);
            this.panel1.ResumeLayout(false);
            this.panelVolumesEmAberto.ResumeLayout(false);
            this.painelLivro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLivroFoto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelVolumesEmAberto;
        private System.Windows.Forms.Panel painelLivro;
        private System.Windows.Forms.Label lbNomeLivro;
        private System.Windows.Forms.PictureBox pbLivroFoto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblQuantidadeLocacoes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblDatasLocacoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}
