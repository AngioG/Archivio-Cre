namespace Archivio_CRE
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_user.Location = new System.Drawing.Point(100, 58);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(200, 23);
            this.txt_user.TabIndex = 2;
            // 
            // txt_psw
            // 
            this.txt_psw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_psw.Location = new System.Drawing.Point(100, 103);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.PasswordChar = '*';
            this.txt_psw.Size = new System.Drawing.Size(200, 23);
            this.txt_psw.TabIndex = 4;
            this.txt_psw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_psw_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(10, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_logo.InitialImage")));
            this.pic_logo.Location = new System.Drawing.Point(331, 1);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(155, 186);
            this.pic_logo.TabIndex = 5;
            this.pic_logo.TabStop = false;
            // 
            // btn_log
            // 
            this.btn_log.Location = new System.Drawing.Point(6, 152);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(294, 35);
            this.btn_log.TabIndex = 6;
            this.btn_log.Text = "ENTRA";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(11, 136);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(141, 13);
            this.lbl_error.TabIndex = 7;
            this.lbl_error.Text = "Credenziali sbagliate, riprova";
            this.lbl_error.Visible = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 199);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivio - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Label lbl_error;
    }
}