using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivio_CRE
{
    public partial class frm_vis : Form
    {
        public frm_vis()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Visualizza();
            frm_login.Aborted = true;
        }


        private void Visualizza()
        {
            list_vis.Items.Clear();
            foreach (var a in Program.GlobalConfig.EleAttivit)
                list_vis.Items.Add(new ListViewItem(new string[] {a.Code,
                a.Nome,
                a.Tipo.ToString(),
                a.Luogo.ToString(),
                a.UltimaModifica.ToString("dd/MM/yyyy")}));
            list_luoghi.Items.Clear();
            foreach (var l in Program.GlobalConfig.EleLuogo)
            {
                cmb_filter_luogo.Items.Add(l);

                list_luoghi.Items.Add(new ListViewItem(new string[] { l.Code, l.Nome, l.Aperto, l.UltimaModifica.ToString("dd/MM/yyyy") }));
            }
            list_attività.Items.Clear();
            foreach (var t in Program.GlobalConfig.EleTipo)
            {
                cmb_filter_tipo.Items.Add(t);

                list_attività.Items.Add(new ListViewItem(new string[] { t.Code, t.Nome, t.UltimaModifica.ToString("dd/MM/yyyy") }));
            }
        }

        private void txt_src_luogo_TextChanged(object sender, EventArgs e)
        {
            Thread nuovo = new Thread((obj) => CercaLuogo());
            nuovo.Name = "CercaLuogo";
            Program.ActiveThreads.RemoveAll(t =>
            {
                if (t.Name == "CercaLuogo")
                {
                    t.Abort();
                    return true;
                }
                return false;
            });
            Program.ActiveThreads.Add(nuovo);
            nuovo.Start();
        }
        private void CercaLuogo()
        {
            var eleCercati = Program.GlobalConfig.EleLuogo.Where(a => a.Nome.ToLower().Contains(txt_src_luogo.Text.ToLower()) || a.Aperto.ToLower().Contains(txt_src_luogo.Text.ToLower())
                                                  || a.Code.ToLower().Contains(txt_src_luogo.Text.ToLower()));
            list_luoghi.Items.Clear();
            foreach (var a in eleCercati.ToList())
            {
                list_luoghi.Items.Add(new ListViewItem(new string[] { a.Code, a.Nome, a.Aperto, a.UltimaModifica.ToString("dd/MM/yyy") }));
                Application.DoEvents();
            }
        }

        private void txt_src_tipo_TextChanged(object sender, EventArgs e)
        {
            Thread nuovo = new Thread((obj) => CercaTipo());
            nuovo.Name = "CercaTipo";
            Program.ActiveThreads.RemoveAll(t =>
            {
                if (t.Name == "CercaTipo")
                {
                    t.Abort();
                    return true;
                }
                return false;
            });
            Program.ActiveThreads.Add(nuovo);
            nuovo.Start();
        }
        private void CercaTipo()
        {
            var eleCercati = Program.GlobalConfig.EleTipo.Where(a => a.Nome.ToLower().Contains(txt_src_luogo.Text.ToLower()) || a.Code.ToLower().Contains(txt_src_luogo.Text.ToLower()));
            list_attività.Items.Clear();
            foreach (var a in eleCercati.ToList())
            {
                list_attività.Items.Add(new ListViewItem(new string[] { a.Code, a.Nome, a.UltimaModifica.ToString("dd/MM/yyy") }));
                Application.DoEvents();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_aggiorna_Click(object sender, EventArgs e)
        {
            interfaccia(false);
            Program.GlobalConfig.Dispose();
            Program.GlobalConfig = GlobalConfiguration.ReadJson();
            Visualizza();
            interfaccia(true);
        }

        private void btn_goto_att_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btn_goto_luoghi_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            (new frm_login()).ShowDialog();
            if (frm_login.Aborted)
                return;
            if (!Program.GlobalConfig.CanInsert)
            {
                MessageBox.Show("Non hai i permessi per modificare l'archivio", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Program.GlobalConfig.Open)
            {
                MessageBox.Show("c'è già qualcuno che sta modificando l'archivio, aspetta il tuo turno!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void interfaccia(bool onoff)
        {
            /*foreach (Control c in tabControl1.SelectedTab.Controls)
                c.Enabled = onoff;*/
            foreach (Control c in Controls)
                c.Enabled = onoff;
        }

        private void list_vis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_vis.SelectedIndices.Count <= 0 || list_vis.SelectedIndices[0] == -1)
                return;

            var cod = list_vis.SelectedItems[0].SubItems[0].Text;
            var att = Program.GlobalConfig.EleAttivit.Where(a => a.Code == cod).FirstOrDefault();
            if (att == null) return;
            (new frm_vis_att(att)).Show();
        }

        private void list_luoghi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_luoghi.SelectedIndices.Count <= 0 || list_luoghi.SelectedIndices[0] == -1)
                return;

            var cod = list_luoghi.SelectedItems[0].SubItems[0].Text;
            var luo = Program.GlobalConfig.EleLuogo.Where(l => l.Code == cod).FirstOrDefault();
            if (luo == null) return;
            (new frm_vis_luo(luo)).Show();
        }

        private void list_attività_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_attività.SelectedIndices.Count <= 0 || list_attività.SelectedIndices[0] == -1)
                return;

            var cod = list_attività.SelectedItems[0].SubItems[0].Text;
            var tipo = Program.GlobalConfig.EleTipo.Where(t => t.Code == cod).FirstOrDefault();
            if (tipo == null) return;
            (new frm_vis_tipo(tipo)).Show();
        }
    }
}
