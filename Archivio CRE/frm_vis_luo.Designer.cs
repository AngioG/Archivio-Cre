
namespace Archivio_CRE
{
    partial class frm_vis_luo
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
            this.label33 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label33.Location = new System.Drawing.Point(20, 125);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(130, 30);
            this.label33.TabIndex = 4;
            this.label33.Text = "Tipo:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nome.Enabled = false;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_nome.Location = new System.Drawing.Point(142, 75);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(320, 30);
            this.txt_nome.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label35.Location = new System.Drawing.Point(20, 75);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(131, 30);
            this.label35.TabIndex = 0;
            this.label35.Text = "Nome:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_tipo
            // 
            this.txt_tipo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_tipo.Enabled = false;
            this.txt_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_tipo.Location = new System.Drawing.Point(142, 125);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(320, 30);
            this.txt_tipo.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(480, 50);
            this.label12.TabIndex = 26;
            this.label12.Text = "LUOGO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_vis_luo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 170);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label35);
            this.Name = "frm_vis_luo";
            this.Text = "Archivio - Visualizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label label12;
    }
}