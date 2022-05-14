
namespace Archivio_CRE
{
    partial class frm_vis
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_aggiorna = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_goto_luoghi = new System.Windows.Forms.Button();
            this.btn_goto_att = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.list_vis = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pan_età = new System.Windows.Forms.Panel();
            this.cmb_filter_età = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pan_luogo = new System.Windows.Forms.Panel();
            this.cmb_filter_luogo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pan_tipo = new System.Windows.Forms.Panel();
            this.cmb_filter_tipo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_src_tipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_src_luogo = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_attività = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_luoghi = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label28 = new System.Windows.Forms.Label();
            this.panel_buttons.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pan_età.SuspendLayout();
            this.pan_luogo.SuspendLayout();
            this.pan_tipo.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1120, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "VISUALIZZAZIONE ARCHIVIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.btn_log);
            this.panel_buttons.Controls.Add(this.btn_aggiorna);
            this.panel_buttons.Controls.Add(this.btn_close);
            this.panel_buttons.Controls.Add(this.btn_goto_luoghi);
            this.panel_buttons.Controls.Add(this.btn_goto_att);
            this.panel_buttons.Location = new System.Drawing.Point(0, 75);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(1120, 50);
            this.panel_buttons.TabIndex = 2;
            // 
            // btn_log
            // 
            this.btn_log.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_log.Location = new System.Drawing.Point(672, 0);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(224, 50);
            this.btn_log.TabIndex = 8;
            this.btn_log.Text = "LOGIN";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_aggiorna
            // 
            this.btn_aggiorna.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_aggiorna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_aggiorna.Location = new System.Drawing.Point(448, 0);
            this.btn_aggiorna.Name = "btn_aggiorna";
            this.btn_aggiorna.Size = new System.Drawing.Size(224, 50);
            this.btn_aggiorna.TabIndex = 7;
            this.btn_aggiorna.Text = "AGGIORNA";
            this.btn_aggiorna.UseVisualStyleBackColor = true;
            this.btn_aggiorna.Click += new System.EventHandler(this.btn_aggiorna_Click);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_close.Location = new System.Drawing.Point(896, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(224, 50);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "ESCI";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_goto_luoghi
            // 
            this.btn_goto_luoghi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_goto_luoghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_goto_luoghi.Location = new System.Drawing.Point(224, 0);
            this.btn_goto_luoghi.Name = "btn_goto_luoghi";
            this.btn_goto_luoghi.Size = new System.Drawing.Size(224, 50);
            this.btn_goto_luoghi.TabIndex = 5;
            this.btn_goto_luoghi.Text = "LUOGHI e TIPI";
            this.btn_goto_luoghi.UseVisualStyleBackColor = true;
            this.btn_goto_luoghi.Click += new System.EventHandler(this.btn_goto_luoghi_Click);
            // 
            // btn_goto_att
            // 
            this.btn_goto_att.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_goto_att.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_goto_att.Location = new System.Drawing.Point(0, 0);
            this.btn_goto_att.Name = "btn_goto_att";
            this.btn_goto_att.Size = new System.Drawing.Size(224, 50);
            this.btn_goto_att.TabIndex = 0;
            this.btn_goto_att.Text = "ATTIVITÀ";
            this.btn_goto_att.UseVisualStyleBackColor = true;
            this.btn_goto_att.Click += new System.EventHandler(this.btn_goto_att_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 622);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.list_vis);
            this.tabPage2.Controls.Add(this.pan_età);
            this.tabPage2.Controls.Add(this.pan_luogo);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.pan_tipo);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1112, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // list_vis
            // 
            this.list_vis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.list_vis.FullRowSelect = true;
            this.list_vis.HideSelection = false;
            this.list_vis.Location = new System.Drawing.Point(280, 77);
            this.list_vis.Name = "list_vis";
            this.list_vis.Size = new System.Drawing.Size(832, 501);
            this.list_vis.TabIndex = 6;
            this.list_vis.UseCompatibleStateImageBehavior = false;
            this.list_vis.View = System.Windows.Forms.View.Details;
            this.list_vis.SelectedIndexChanged += new System.EventHandler(this.list_vis_SelectedIndexChanged);
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
            // columnHeader20
            // 
            this.columnHeader20.Text = "Ultima Modifica";
            this.columnHeader20.Width = 120;
            // 
            // pan_età
            // 
            this.pan_età.Controls.Add(this.cmb_filter_età);
            this.pan_età.Controls.Add(this.label16);
            this.pan_età.Location = new System.Drawing.Point(15, 320);
            this.pan_età.Name = "pan_età";
            this.pan_età.Size = new System.Drawing.Size(200, 66);
            this.pan_età.TabIndex = 5;
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
            "Elementari",
            "Medie",
            "Tutte"});
            this.cmb_filter_età.Location = new System.Drawing.Point(0, 30);
            this.cmb_filter_età.Name = "cmb_filter_età";
            this.cmb_filter_età.Size = new System.Drawing.Size(200, 28);
            this.cmb_filter_età.TabIndex = 17;
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
            this.pan_luogo.Location = new System.Drawing.Point(15, 225);
            this.pan_luogo.Name = "pan_luogo";
            this.pan_luogo.Size = new System.Drawing.Size(200, 66);
            this.pan_luogo.TabIndex = 4;
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
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label14.Location = new System.Drawing.Point(10, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 26);
            this.label14.TabIndex = 3;
            this.label14.Text = "Filtra per:";
            // 
            // pan_tipo
            // 
            this.pan_tipo.Controls.Add(this.cmb_filter_tipo);
            this.pan_tipo.Controls.Add(this.label13);
            this.pan_tipo.Location = new System.Drawing.Point(15, 130);
            this.pan_tipo.Name = "pan_tipo";
            this.pan_tipo.Size = new System.Drawing.Size(200, 65);
            this.pan_tipo.TabIndex = 2;
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
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1106, 50);
            this.label12.TabIndex = 1;
            this.label12.Text = "ESPLORA L\'ARCHIVIO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txt_src_tipo);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txt_src_luogo);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.list_attività);
            this.tabPage4.Controls.Add(this.list_luoghi);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1112, 594);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_src_tipo
            // 
            this.txt_src_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_src_tipo.Location = new System.Drawing.Point(636, 83);
            this.txt_src_tipo.Name = "txt_src_tipo";
            this.txt_src_tipo.Size = new System.Drawing.Size(451, 30);
            this.txt_src_tipo.TabIndex = 15;
            this.txt_src_tipo.TextChanged += new System.EventHandler(this.txt_src_tipo_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(631, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cerca:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_src_luogo
            // 
            this.txt_src_luogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_src_luogo.Location = new System.Drawing.Point(25, 83);
            this.txt_src_luogo.Name = "txt_src_luogo";
            this.txt_src_luogo.Size = new System.Drawing.Size(450, 30);
            this.txt_src_luogo.TabIndex = 13;
            this.txt_src_luogo.TextChanged += new System.EventHandler(this.txt_src_luogo_TextChanged);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label27.Location = new System.Drawing.Point(20, 50);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 30);
            this.label27.TabIndex = 12;
            this.label27.Text = "Cerca:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.Location = new System.Drawing.Point(553, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 50);
            this.label2.TabIndex = 11;
            this.label2.Text = "TIPO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_attività
            // 
            this.list_attività.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader16});
            this.list_attività.HideSelection = false;
            this.list_attività.Location = new System.Drawing.Point(635, 125);
            this.list_attività.Name = "list_attività";
            this.list_attività.Size = new System.Drawing.Size(450, 462);
            this.list_attività.TabIndex = 10;
            this.list_attività.UseCompatibleStateImageBehavior = false;
            this.list_attività.View = System.Windows.Forms.View.Details;
            this.list_attività.SelectedIndexChanged += new System.EventHandler(this.list_attività_SelectedIndexChanged);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Codice";
            this.columnHeader13.Width = 110;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Nome";
            this.columnHeader14.Width = 150;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Ultima Modifica";
            this.columnHeader16.Width = 120;
            // 
            // list_luoghi
            // 
            this.list_luoghi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11,
            this.columnHeader12});
            this.list_luoghi.HideSelection = false;
            this.list_luoghi.Location = new System.Drawing.Point(25, 125);
            this.list_luoghi.Name = "list_luoghi";
            this.list_luoghi.Size = new System.Drawing.Size(450, 462);
            this.list_luoghi.TabIndex = 5;
            this.list_luoghi.UseCompatibleStateImageBehavior = false;
            this.list_luoghi.View = System.Windows.Forms.View.Details;
            this.list_luoghi.SelectedIndexChanged += new System.EventHandler(this.list_luoghi_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Codice";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nome";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tipo";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ultima Modifica";
            this.columnHeader12.Width = 100;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label28.Location = new System.Drawing.Point(1, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(553, 50);
            this.label28.TabIndex = 3;
            this.label28.Text = "LUOGHI";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_vis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 720);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "frm_vis";
            this.Text = "Archivio - Visualizza";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel_buttons.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pan_età.ResumeLayout(false);
            this.pan_luogo.ResumeLayout(false);
            this.pan_tipo.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_goto_luoghi;
        private System.Windows.Forms.Button btn_goto_att;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView list_vis;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.Panel pan_età;
        private System.Windows.Forms.ComboBox cmb_filter_età;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pan_luogo;
        private System.Windows.Forms.ComboBox cmb_filter_luogo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pan_tipo;
        private System.Windows.Forms.ComboBox cmb_filter_tipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView list_attività;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ListView list_luoghi;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_src_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_src_luogo;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_aggiorna;
    }
}