
namespace Presentation.Views
{
    partial class FormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.panelNavbarHolder = new System.Windows.Forms.Panel();
            this.panelViewHolder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelNavbarHolder
            // 
            this.panelNavbarHolder.BackColor = System.Drawing.Color.Transparent;
            this.panelNavbarHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbarHolder.Location = new System.Drawing.Point(0, 0);
            this.panelNavbarHolder.Name = "panelNavbarHolder";
            this.panelNavbarHolder.Size = new System.Drawing.Size(800, 65);
            this.panelNavbarHolder.TabIndex = 0;
            // 
            // panelViewHolder
            // 
            this.panelViewHolder.BackColor = System.Drawing.Color.Transparent;
            this.panelViewHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewHolder.Location = new System.Drawing.Point(0, 65);
            this.panelViewHolder.Name = "panelViewHolder";
            this.panelViewHolder.Size = new System.Drawing.Size(800, 450);
            this.panelViewHolder.TabIndex = 1;
            // 
            // FormBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.panelViewHolder);
            this.Controls.Add(this.panelNavbarHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Central Comunitária";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbarHolder;
        private System.Windows.Forms.Panel panelViewHolder;
    }
}