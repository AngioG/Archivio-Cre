
namespace Archivio_CRE
{
    partial class frm_exp
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
            this.list_src = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_filter_tipo = new System.Windows.Forms.ComboBox();
            this.pan_età = new System.Windows.Forms.Panel();
            this.cmb_filter_età = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pan_luogo = new System.Windows.Forms.Panel();
            this.cmb_filter_luogo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pan_tipo = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_src = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.pan_età.SuspendLayout();
            this.pan_luogo.SuspendLayout();
            this.pan_tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_src
            // 
            this.list_src.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.list_src.FullRowSelect = true;
            this.list_src.HideSelection = false;
            this.list_src.Location = new System.Drawing.Point(275, 75);
            this.list_src.Name = "list_src";
            this.list_src.Size = new System.Drawing.Size(707, 509);
            this.list_src.TabIndex = 11;
            this.list_src.UseCompatibleStateImageBehavior = false;
            this.list_src.View = System.Windows.Forms.View.Details;
            this.list_src.SelectedIndexChanged += new System.EventHandler(this.list_src_SelectedIndexChanged);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Codice";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Nome";
            this.columnHeader17.Width = 220;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Tipo";
            this.columnHeader18.Width = 180;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Luogo";
            this.columnHeader19.Width = 180;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label14.Location = new System.Drawing.Point(3, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 26);
            this.label14.TabIndex = 8;
            this.label14.Text = "Filtra per:";
            // 
            // cmb_filter_tipo
            // 
            this.cmb_filter_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_filter_tipo.FormattingEnabled = true;
            this.cmb_filter_tipo.Items.AddRange(new object[] {
            "Tutti"});
            this.cmb_filter_tipo.Location = new System.Drawing.Point(0, 30);
            this.cmb_filter_tipo.Name = "cmb_filter_tipo";
            this.cmb_filter_tipo.Size = new System.Drawing.Size(200, 28);
            this.cmb_filter_tipo.TabIndex = 1;
            this.cmb_filter_tipo.SelectedIndexChanged += new System.EventHandler(this.Cerca);
            // 
            // pan_età
            // 
            this.pan_età.Controls.Add(this.cmb_filter_età);
            this.pan_età.Controls.Add(this.label16);
            this.pan_età.Location = new System.Drawing.Point(8, 441);
            this.pan_età.Name = "pan_età";
            this.pan_età.Size = new System.Drawing.Size(200, 66);
            this.pan_età.TabIndex = 10;
            // 
            // cmb_filter_età
            // 
            this.cmb_filter_età.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter_età.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_filter_età.FormattingEnabled = true;
            this.cmb_filter_età.Items.AddRange(new object[] {
            "Prima Elementare",
            "Seconda Elementare",
            "Terza Elementare",
            "Quarta Elementare",
            "Quinta Elementare",
            "Prima Media",
            "Seconda Media",
            "Terza Media",
            "Tutte"});
            this.cmb_filter_età.Location = new System.Drawing.Point(0, 29);
            this.cmb_filter_età.Name = "cmb_filter_età";
            this.cmb_filter_età.Size = new System.Drawing.Size(200, 28);
            this.cmb_filter_età.TabIndex = 17;
            this.cmb_filter_età.SelectedIndexChanged += new System.EventHandler(this.Cerca);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 26);
            this.label16.TabIndex = 0;
            this.label16.Text = "Età:";
            // 
            // pan_luogo
            // 
            this.pan_luogo.Controls.Add(this.cmb_filter_luogo);
            this.pan_luogo.Controls.Add(this.label15);
            this.pan_luogo.Location = new System.Drawing.Point(8, 346);
            this.pan_luogo.Name = "pan_luogo";
            this.pan_luogo.Size = new System.Drawing.Size(200, 66);
            this.pan_luogo.TabIndex = 9;
            // 
            // cmb_filter_luogo
            // 
            this.cmb_filter_luogo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter_luogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_filter_luogo.FormattingEnabled = true;
            this.cmb_filter_luogo.Items.AddRange(new object[] {
            "Tutti",
            "Aperti",
            "Chiusi"});
            this.cmb_filter_luogo.Location = new System.Drawing.Point(0, 30);
            this.cmb_filter_luogo.Name = "cmb_filter_luogo";
            this.cmb_filter_luogo.Size = new System.Drawing.Size(200, 28);
            this.cmb_filter_luogo.TabIndex = 1;
            this.cmb_filter_luogo.SelectedIndexChanged += new System.EventHandler(this.Cerca);
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "Luogo:";
            // 
            // pan_tipo
            // 
            this.pan_tipo.Controls.Add(this.cmb_filter_tipo);
            this.pan_tipo.Controls.Add(this.label13);
            this.pan_tipo.Location = new System.Drawing.Point(8, 251);
            this.pan_tipo.Name = "pan_tipo";
            this.pan_tipo.Size = new System.Drawing.Size(200, 65);
            this.pan_tipo.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tipo:";
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(994, 50);
            this.label12.TabIndex = 12;
            this.label12.Text = "SELEZIONA L\'ATTIVITÀ DA ESPORTARE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_src
            // 
            this.txt_src.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_src.Location = new System.Drawing.Point(8, 108);
            this.txt_src.Name = "txt_src";
            this.txt_src.Size = new System.Drawing.Size(202, 30);
            this.txt_src.TabIndex = 14;
            this.txt_src.TextChanged += new System.EventHandler(this.Cerca);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label27.Location = new System.Drawing.Point(3, 75);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 30);
            this.label27.TabIndex = 13;
            this.label27.Text = "Cerca:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_exp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 611);
            this.Controls.Add(this.txt_src);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.list_src);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pan_età);
            this.Controls.Add(this.pan_luogo);
            this.Controls.Add(this.pan_tipo);
            this.Name = "frm_exp";
            this.Text = "Archivio - Esporta";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.pan_età.ResumeLayout(false);
            this.pan_luogo.ResumeLayout(false);
            this.pan_tipo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_src;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_filter_tipo;
        private System.Windows.Forms.Panel pan_età;
        private System.Windows.Forms.ComboBox cmb_filter_età;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pan_luogo;
        private System.Windows.Forms.ComboBox cmb_filter_luogo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pan_tipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_src;
        private System.Windows.Forms.Label label27;
    }
}