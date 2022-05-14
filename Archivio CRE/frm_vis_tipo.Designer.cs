
namespace Archivio_CRE
{
    partial class frm_vis_tipo
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
            this.txt_des = new System.Windows.Forms.RichTextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_des
            // 
            this.txt_des.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_des.Enabled = false;
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_des.Location = new System.Drawing.Point(142, 135);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(320, 150);
            this.txt_des.TabIndex = 15;
            this.txt_des.Text = "";
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label41.Location = new System.Drawing.Point(12, 135);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(130, 30);
            this.label41.TabIndex = 14;
            this.label41.Text = "Descrizione";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nome.Enabled = false;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_nome.Location = new System.Drawing.Point(142, 75);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(320, 30);
            this.txt_nome.TabIndex = 13;
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label42.Location = new System.Drawing.Point(12, 75);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(131, 30);
            this.label42.TabIndex = 12;
            this.label42.Text = "Nome:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(480, 50);
            this.label12.TabIndex = 16;
            this.label12.Text = "TIPO DI ATTIVITÀ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_vis_tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label42);
            this.Name = "frm_vis_tipo";
            this.Text = "Archivio - Visualizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_des;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label12;
    }
}