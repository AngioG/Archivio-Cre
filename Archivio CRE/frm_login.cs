using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivio_CRE
{
    public partial class frm_login : Form
    {
        public static bool Aborted;
        public frm_login()
        {
            InitializeComponent();

        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if(Program.GlobalConfig.ActiveLogin != null && String.IsNullOrWhiteSpace(txt_user.Text))
            {
                if (Program.GlobalConfig.Open)
                    MessageBox.Show("Qualcuno sta già modificando l'archivio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Aborted = false;
                this.Close();
            }


            var account = Program.GlobalConfig.EleLogin.Where(l => l.Nome == txt_user.Text).FirstOrDefault();
            if (account == null)
            {
                lbl_error.Visible = true;
                return;
            }

            if (String.IsNullOrWhiteSpace(account.Password))
                account.InsertPassword(txt_psw.Text);

            if (!account.PasswordCorrect(txt_psw.Text))
            {
                lbl_error.Visible = true;
                return;
            }

            if (Program.GlobalConfig.Open)
                MessageBox.Show("Qualcuno sta già modificando l'archivio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Program.GlobalConfig.ActiveLogin = account;
            Aborted = false;
            this.Close();
        }

        private void txt_psw_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_log.PerformClick();
        }

    }
}
