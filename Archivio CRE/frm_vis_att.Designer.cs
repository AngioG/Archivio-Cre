
namespace Archivio_CRE
{
    partial class frm_vis_att
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
            this.label11 = new System.Windows.Forms.Label();
            this.list_classi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.list_materiali = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_fields = new System.Windows.Forms.Panel();
            this.txt_luogo = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_fields.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(495, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 27);
            this.label11.TabIndex = 24;
            this.label11.Text = "Target:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // list_classi
            // 
            this.list_classi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.list_classi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.list_classi.Enabled = false;
            this.list_classi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.list_classi.FullRowSelect = true;
            this.list_classi.HideSelection = false;
            this.list_classi.Location = new System.Drawing.Point(500, 375);
            this.list_classi.Name = "list_classi";
            this.list_classi.Size = new System.Drawing.Size(275, 130);
            this.list_classi.TabIndex = 23;
            this.list_classi.UseCompatibleStateImageBehavior = false;
            this.list_classi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Classi";
            this.columnHeader4.Width = 250;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(500, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 30);
            this.label8.TabIndex = 22;
            this.label8.Text = "Materiali:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // list_materiali
            // 
            this.list_materiali.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.list_materiali.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.list_materiali.Enabled = false;
            this.list_materiali.FullRowSelect = true;
            this.list_materiali.HideSelection = false;
            this.list_materiali.Location = new System.Drawing.Point(500, 110);
            this.list_materiali.Name = "list_materiali";
            this.list_materiali.Size = new System.Drawing.Size(275, 217);
            this.list_materiali.TabIndex = 21;
            this.list_materiali.UseCompatibleStateImageBehavior = false;
            this.list_materiali.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Q.tà";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 230;
            // 
            // panel_fields
            // 
            this.panel_fields.Controls.Add(this.txt_luogo);
            this.panel_fields.Controls.Add(this.txt_tipo);
            this.panel_fields.Controls.Add(this.label45);
            this.panel_fields.Controls.Add(this.label44);
            this.panel_fields.Controls.Add(this.txt_des);
            this.panel_fields.Controls.Add(this.label6);
            this.panel_fields.Controls.Add(this.label5);
            this.panel_fields.Controls.Add(this.label4);
            this.panel_fields.Controls.Add(this.txt_nome);
            this.panel_fields.Controls.Add(this.label3);
            this.panel_fields.Location = new System.Drawing.Point(20, 75);
            this.panel_fields.Name = "panel_fields";
            this.panel_fields.Size = new System.Drawing.Size(450, 438);
            this.panel_fields.TabIndex = 20;
            this.panel_fields.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frm_vis_att_MouseClick);
            // 
            // txt_luogo
            // 
            this.txt_luogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_luogo.Enabled = false;
            this.txt_luogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_luogo.Location = new System.Drawing.Point(130, 340);
            this.txt_luogo.Name = "txt_luogo";
            this.txt_luogo.Size = new System.Drawing.Size(320, 30);
            this.txt_luogo.TabIndex = 20;
            // 
            // txt_tipo
            // 
            this.txt_tipo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_tipo.Enabled = false;
            this.txt_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_tipo.Location = new System.Drawing.Point(130, 400);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(320, 30);
            this.txt_tipo.TabIndex = 19;
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label45.Location = new System.Drawing.Point(0, 120);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(130, 30);
            this.label45.TabIndex = 18;
            this.label45.Text = "Osservazioni:";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label44.Location = new System.Drawing.Point(0, 90);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(130, 30);
            this.label44.TabIndex = 17;
            this.label44.Text = "ed eventuali";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_des
            // 
            this.txt_des.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_des.Enabled = false;
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_des.Location = new System.Drawing.Point(130, 60);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(320, 250);
            this.txt_des.TabIndex = 9;
            this.txt_des.Text = "";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(0, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(0, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Luogo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(0, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descrizione";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_nome.Enabled = false;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_nome.Location = new System.Drawing.Point(130, 0);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(320, 30);
            this.txt_nome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(795, 50);
            this.label12.TabIndex = 25;
            this.label12.Text = "ATTIVITÀ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_vis_att
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 525);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.list_classi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.list_materiali);
            this.Controls.Add(this.panel_fields);
            this.Name = "frm_vis_att";
            this.Text = "Archivio - Visualizza";
            this.panel_fields.ResumeLayout(false);
            this.panel_fields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView list_classi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView list_materiali;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel_fields;
        private System.Windows.Forms.TextBox txt_luogo;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.RichTextBox txt_des;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
    }
}