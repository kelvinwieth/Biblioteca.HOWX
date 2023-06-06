
namespace Presentation.Views
{
    partial class NavbarControl
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
            this.tlpNavbar = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblRaComNomeEstudante = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbInputPesquisa = new System.Windows.Forms.TextBox();
            this.tlpNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpNavbar
            // 
            this.tlpNavbar.ColumnCount = 3;
            this.tlpNavbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.75F));
            this.tlpNavbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.875F));
            this.tlpNavbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.375F));
            this.tlpNavbar.Controls.Add(this.pbLogo, 0, 0);
            this.tlpNavbar.Controls.Add(this.lblRaComNomeEstudante, 1, 0);
            this.tlpNavbar.Controls.Add(this.panel1, 2, 0);
            this.tlpNavbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNavbar.Location = new System.Drawing.Point(0, 0);
            this.tlpNavbar.Name = "tlpNavbar";
            this.tlpNavbar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tlpNavbar.RowCount = 1;
            this.tlpNavbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNavbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpNavbar.Size = new System.Drawing.Size(800, 65);
            this.tlpNavbar.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::Presentation.Properties.Resources.univali_logo_2;
            this.pbLogo.Location = new System.Drawing.Point(3, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(112, 53);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblRaComNomeEstudante
            // 
            this.lblRaComNomeEstudante.AutoSize = true;
            this.lblRaComNomeEstudante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRaComNomeEstudante.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRaComNomeEstudante.ForeColor = System.Drawing.Color.White;
            this.lblRaComNomeEstudante.Location = new System.Drawing.Point(121, 3);
            this.lblRaComNomeEstudante.Name = "lblRaComNomeEstudante";
            this.lblRaComNomeEstudante.Size = new System.Drawing.Size(321, 59);
            this.lblRaComNomeEstudante.TabIndex = 1;
            this.lblRaComNomeEstudante.Text = "RA 7812912984712 - José Pereira";
            this.lblRaComNomeEstudante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.tbInputPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(448, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 53);
            this.panel1.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnHome.Image = global::Presentation.Properties.Resources.home16;
            this.btnHome.Location = new System.Drawing.Point(19, 14);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(28, 28);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Location = new System.Drawing.Point(258, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(78, 28);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // tbInputPesquisa
            // 
            this.tbInputPesquisa.Font = new System.Drawing.Font("Arial", 14.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInputPesquisa.Location = new System.Drawing.Point(66, 13);
            this.tbInputPesquisa.Name = "tbInputPesquisa";
            this.tbInputPesquisa.PlaceholderText = "Pesquisar livro";
            this.tbInputPesquisa.Size = new System.Drawing.Size(192, 30);
            this.tbInputPesquisa.TabIndex = 0;
            this.tbInputPesquisa.Text = "guerra";
            this.tbInputPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NavbarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.Controls.Add(this.tlpNavbar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.Name = "NavbarControl";
            this.Size = new System.Drawing.Size(800, 65);
            this.tlpNavbar.ResumeLayout(false);
            this.tlpNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNavbar;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblRaComNomeEstudante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox tbInputPesquisa;
        private System.Windows.Forms.Button btnHome;
    }
}
