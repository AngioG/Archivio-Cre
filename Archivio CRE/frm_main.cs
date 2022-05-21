using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Archivio_CRE
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            cmb_filter_luogo.SelectedIndex = 0;
            cmb_filter_tipo.SelectedIndex = 0;
            cmb_filter_età.SelectedIndex = 10;
            CheckForIllegalCrossThreadCalls = false;
        }



        #region Generale
        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var l in Program.GlobalConfig.EleLuogo)
            {
                cmb_ins_luogo.Items.Add(l);
                cmb_filter_luogo.Items.Add(l);
                cmb_edit_luogo.Items.Add(l);

                list_luoghi.Items.Add(new ListViewItem(new string[] { l.Code, l.Nome, l.Aperto}));
            }
            foreach (var t in Program.GlobalConfig.EleTipo)
            {
                cmb_ins_tipo.Items.Add(t);
                cmb_filter_tipo.Items.Add(t);
                cmb_edit_tipo.Items.Add(t);

                list_attività.Items.Add(new ListViewItem(new string[] { t.Code, t.Nome}));
            }

            Thread nuovo = new Thread(CheckIfStop);
            nuovo.Name = "Chiusura";
            Program.ActiveThreads.Add(nuovo);
            nuovo.Start();

            Program.timeLeft = 600000;
        }
        private void change_index(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (sender as Button).TabIndex;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                Visualizza(sender, e);
            if (tabControl1.SelectedIndex == 2)
            {
                list_src.Items.Clear();
                foreach (var a in Program.GlobalConfig.EleAttivit)
                    list_src.Items.Add(new ListViewItem(new string[] { a.Code, a.Nome }));
            }
            if (tabControl1.SelectedIndex == 3)
            {
                list_luoghi.Items.Clear();
                foreach (var l in Program.GlobalConfig.EleLuogo)
                    list_luoghi.Items.Add(new ListViewItem(new string[] { l.Code, l.Nome, l.Aperto}));
                }
            if (tabControl1.SelectedIndex == 4)
            {
                list_attività.Items.Clear();
                foreach (var t in Program.GlobalConfig.EleTipo)
                    list_attività.Items.Add(new ListViewItem(new string[] { t.Code, t.Nome}));
            }


        }
        private void Quit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var t in Program.ActiveThreads)
                t.Abort();
            Program.GlobalConfig.Open = false;
            Program.GlobalConfig.WriteToFile();
        }
        #endregion
        #region Tab 1 Inserimento
        private void btn_addtogrid_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ins_materiale.Text))
                return;

            foreach (ListViewItem i in list_materiali.Items)
            {
                if (i.SubItems[1].Text == txt_ins_materiale.Text)
                {
                    i.SubItems[0].Text = (int.Parse(i.SubItems[0].Text) + 1).ToString();
                    return;
                }
            }

            list_materiali.Items.Add(new ListViewItem(new string[] { "1", txt_ins_materiale.Text }));

            Program.timeLeft = 600000;
        }
        private void list_materiali_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_materiali.SelectedIndices.Count != 1)
            {
                btn_meno_materiale.Enabled = false;
                btn_rm_materiale.Enabled = false;
                btn_piu_materiale.Enabled = false;

                txt_selected.Text = "";

                return;
            }


            txt_selected.Text = list_materiali.SelectedItems[0].SubItems[1].Text;

            if (int.Parse(list_materiali.SelectedItems[0].SubItems[0].Text) != 1)
                btn_meno_materiale.Enabled = true;
            else
                btn_meno_materiale.Enabled = false;

            btn_rm_materiale.Enabled = true;
            btn_piu_materiale.Enabled = true;

            Program.timeLeft = 600000;
        }
        private void btn_piu_materiale_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_selected.Text))
                return;

            foreach (ListViewItem i in list_materiali.Items)
            {
                if (i.SubItems[1].Text == txt_selected.Text)
                {
                    i.SubItems[0].Text = (int.Parse(i.SubItems[0].Text) + 1).ToString();
                    break;
                }
            }

            btn_meno_materiale.Enabled = true;

            Program.timeLeft = 600000;
        }
        private void btn_meno_materiale_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_selected.Text))
                return;

            foreach (ListViewItem i in list_materiali.Items)
            {
                if (i.SubItems[1].Text == txt_selected.Text)
                {
                    int n = int.Parse(i.SubItems[0].Text);
                    if (n <= 2)
                        btn_meno_materiale.Enabled = false;
                    if (n <= 1)
                        return;
                    i.SubItems[0].Text = (n - 1).ToString();
                    break;
                }
            }

            Program.timeLeft = 600000;
        }
        private void btn_rm_materiale_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_selected.Text))
                return;

            foreach (ListViewItem i in list_classi.Items)
            {
                if (i.SubItems[0].Text == txt_selected.Text)
                {
                    list_classi.Items.Remove(i);
                    return;
                }
            }
            foreach (ListViewItem i in list_materiali.Items)
            {
                if (i.SubItems[1].Text == txt_selected.Text)
                {
                    list_materiali.Items.Remove(i);
                    return;
                }
            }

            Program.timeLeft = 600000;
        }
        private void list_classi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_classi.SelectedIndices.Count != 1)
            {
                btn_meno_materiale.Enabled = false;
                btn_rm_materiale.Enabled = false;
                btn_piu_materiale.Enabled = false;

                txt_selected.Text = "";

                return;
            }

            txt_selected.Text = list_classi.SelectedItems[0].SubItems[0].Text;

            btn_meno_materiale.Enabled = false;
            btn_rm_materiale.Enabled = true;
            btn_piu_materiale.Enabled = false;

            Program.timeLeft = 600000;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ins_nome.Text = "";
            txt_ins_des.Text = "";
            cmb_ins_classe.SelectedIndex = -1;
            cmb_ins_luogo.SelectedIndex = -1;
            cmb_ins_tipo.SelectedIndex = -1;
            txt_ins_materiale.Text = "";
            list_materiali.Items.Clear();
            list_classi.Items.Clear();
            txt_selected.Text = "";
            btn_meno_materiale.Enabled = false;
            btn_rm_materiale.Enabled = false;
            btn_piu_materiale.Enabled = false;

            Program.timeLeft = 600000;
        }
        private void Inserisci(object sender, EventArgs e)
        {
            List<string> eleetà = new List<string>();
            foreach (ListViewItem i in list_classi.Items)
                eleetà.Add(i.Text);

            List<(int, string)> elemateriali = new List<(int, string)>();
            foreach (ListViewItem i in list_materiali.Items)
            {
                (int, string) a = (int.Parse(i.SubItems[0].Text), i.SubItems[1].Text);
                elemateriali.Add(a);
            }

            Attività nuova = null;
            try
            {
                nuova = new Attività(txt_ins_nome.Text, txt_ins_des.Text, eleetà, cmb_ins_luogo.SelectedItem as Luogo, cmb_ins_tipo.SelectedItem as Tipo, elemateriali);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (nuova != null)
            {
                Program.GlobalConfig.EleAttivit.Add(nuova);
                btn_clear_Click(sender, e);
            }
            else
                MessageBox.Show("Errore inaspettato, riprova", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Program.timeLeft = 600000;
        }
        #endregion
        #region tab 2 Visualizza
        private void Visualizza(object sender, EventArgs e)
        {
            var eleVis = Program.GlobalConfig.EleAttivit.Select(a => new
            {
                Codice = a.Code,
                a.Nome,
                a.Luogo,
                a.Tipo,
                a.Età
            });

            if (cmb_filter_tipo.Text != "Tutti")
                eleVis = eleVis.Where(a => a.Tipo == cmb_filter_tipo.SelectedItem as Tipo);

            switch (cmb_filter_luogo.Text)
            {
                case "Tutti": break;
                case "Aperti":
                    {
                        eleVis = eleVis.Where(a => a.Luogo.Aperto == "Aperto");
                        break;
                    }
                case "Chiusi":
                    {
                        eleVis = eleVis.Where(a => a.Luogo.Aperto == "Chiuso");
                        break;
                    }
                default:
                    {
                        eleVis = eleVis.Where(a => a.Luogo == cmb_filter_luogo.SelectedItem as Luogo);
                        break;
                    }

            }

            switch (cmb_filter_età.Text)
            {
                case "Tutte": break;
                case "Medie":
                    {
                        eleVis = eleVis.Where(a => a.Età.Contains("Prima Media") && a.Età.Contains("Seconda Media") && a.Età.Contains("Terza Media"));
                        break;
                    }
                case "Elementari":
                    {
                        eleVis = eleVis.Where(a => a.Età.Contains("Prima Elementare") && a.Età.Contains("Seconda Elementare") && a.Età.Contains("Terza Elementare") && a.Età.Contains("Quarta Elementare") && a.Età.Contains("Quinta Elementare"));
                        break;
                    }
                default:
                    {
                        eleVis = eleVis.Where(a => a.Età.Contains(cmb_filter_età.Text));
                        break;
                    }

            }

            list_vis.Items.Clear();
            foreach (var a in eleVis)
            {
                list_vis.Items.Add(new ListViewItem(new string[] {a.Codice,
                a.Nome,
                a.Tipo.ToString(),
                a.Luogo.ToString()}));
            }

            Program.timeLeft = 600000;
        }
        #endregion
        #region Tab 3 Modifica
        private void txt_src_TextChanged(object sender, EventArgs e)
        {
            Thread nuovo = new Thread((obj) => Cerca());
            nuovo.Name = "Cerca";
            Program.ActiveThreads.RemoveAll(t =>
            {
                if (t.Name == "Cerca")
                {
                    t.Abort();
                    return true;
                }
                return false;
            });
            Program.ActiveThreads.Add(nuovo);
            nuovo.Start();
            Program.timeLeft = 600000;
        }
        private void Cerca()
        {
            var eleCercati = Program.GlobalConfig.EleAttivit.Where(a => a.Nome.ToLower().Contains(txt_src.Text.ToLower()) || a.Luogo.Nome.ToLower().Contains(txt_src.Text.ToLower())
                                                      || a.Tipo.Nome.ToLower().Contains(txt_src.Text.ToLower()) || a.Code.ToLower().Contains(txt_src.Text.ToLower()));
            list_src.Items.Clear();
            foreach (var a in eleCercati.ToList())
            {
                list_src.Items.Add(new ListViewItem(new string[] { a.Code, a.Nome }));
                Application.DoEvents();
            }
        }
        private void list_src_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_src.SelectedIndices.Count != 1)
                return;

            var selected = Program.GlobalConfig.EleAttivit.Where(l => l.Code == list_src.SelectedItems[0].SubItems[0].Text).FirstOrDefault();

            if (selected == null) return;

            txt_edit_cod.Text = selected.Code;
            txt_edit_nom.Text = selected.Nome;
            txt_edit_des.Text = selected.Descrizione;
            cmb_edit_luogo.SelectedItem = selected.Luogo;
            cmb_edit_tipo.SelectedItem = selected.Tipo;
            list_edit_classi.Items.Clear();
            foreach (var s in selected.Età)
                list_edit_classi.Items.Add(new ListViewItem(s));
            list_edit_mat.Items.Clear();
            foreach (var o in selected.Materiale)
                list_edit_mat.Items.Add(new ListViewItem(new string[] { o.Item1.ToString(), o.Item2 }));

            pan_edit.Enabled = true;
            pan_edit1.Enabled = true;
        }
        private void list_edit_mat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_edit_mat.SelectedIndices.Count != 1)
            {
                btn_meno_edit.Enabled = false;
                btn_rm_edit.Enabled = false;
                btn_più_edit.Enabled = false;

                txt_selected_edit.Text = "";

                return;
            }


            txt_selected_edit.Text = list_edit_mat.SelectedItems[0].SubItems[1].Text;

            if (int.Parse(list_edit_mat.SelectedItems[0].SubItems[0].Text) != 1)
                btn_meno_edit.Enabled = true;
            else
                btn_meno_edit.Enabled = false;

            btn_rm_edit.Enabled = true;
            btn_più_edit.Enabled = true;
        }
        private void btn_piu_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_selected_edit.Text))
                return;

            foreach (ListViewItem i in list_edit_mat.Items)
            {
                if (i.SubItems[1].Text == txt_selected_edit.Text)
                {
                    i.SubItems[0].Text = (int.Parse(i.SubItems[0].Text) + 1).ToString();
                    break;
                }
            }

            btn_meno_materiale.Enabled = true;
        }
        private void btn_meno_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_selected_edit.Text))
                return;

            foreach (ListViewItem i in list_edit_mat.Items)
            {
                if (i.SubItems[1].Text == txt_selected_edit.Text)
                {
                    int n = int.Parse(i.SubItems[0].Text);
                    if (n <= 2)
                        btn_meno_edit.Enabled = false;
                    if (n <= 1)
                        return;
                    i.SubItems[0].Text = (n - 1).ToString();
                    break;
                }
            }
        }
        private void btn_rm_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_selected_edit.Text))
                return;

            foreach (ListViewItem i in list_classi.Items)
            {
                if (i.SubItems[0].Text == txt_selected_edit.Text)
                {
                    list_edit_classi.Items.Remove(i);
                    return;
                }
            }
            foreach (ListViewItem i in list_edit_mat.Items)
            {
                if (i.SubItems[1].Text == txt_selected_edit.Text)
                {
                    list_edit_mat.Items.Remove(i);
                    return;
                }
            }
        }
        private void btn_rm_att_Click(object sender, EventArgs e)
        {
            Program.GlobalConfig.EleAttivit.RemoveAll(a => a.Code == txt_edit_cod.Text);

            Clear_edit(sender, e);
            list_src.Items.Clear();
            foreach (var a in Program.GlobalConfig.EleAttivit)
                list_src.Items.Add(new ListViewItem(new string[] { a.Code, a.Nome }));
        }
        private void btn_edit_mat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_edit_mat.Text))
                return;

            foreach (ListViewItem i in list_edit_mat.Items)
            {
                if (i.SubItems[1].Text == txt_edit_mat.Text)
                {
                    i.SubItems[0].Text = (int.Parse(i.SubItems[0].Text) + 1).ToString();
                    return;
                }
            }

            list_edit_mat.Items.Add(new ListViewItem(new string[] { "1", txt_edit_mat.Text }));
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selected = Program.GlobalConfig.EleAttivit.Where(a => a.Code == txt_edit_cod.Text).FirstOrDefault();

            if (selected == null) return;

            List<string> eleetà = new List<string>();
            foreach (ListViewItem i in list_edit_classi.Items)
                eleetà.Add(i.Text);

            List<(int, string)> elemateriali = new List<(int, string)>();
            foreach (ListViewItem i in list_edit_mat.Items)
            {
                (int, string) a = (int.Parse(i.SubItems[0].Text), i.SubItems[1].Text);
                elemateriali.Add(a);
            }

            try
            {
                selected.Nome = txt_edit_nom.Text;
                selected.Descrizione = txt_edit_des.Text;
                selected.Età = eleetà;
                selected.Materiale = elemateriali;
                selected.Luogo = Program.GlobalConfig.EleLuogo.Where(l => l.Nome == cmb_edit_luogo.Text).FirstOrDefault();
                selected.Tipo = Program.GlobalConfig.EleTipo.Where(t => t.Nome == cmb_edit_tipo.Text).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            list_src.Items.Clear();
            foreach (var a in Program.GlobalConfig.EleAttivit)
                list_src.Items.Add(new ListViewItem(new string[] { a.Code, a.Nome }));

            Clear_edit(sender, e);
            Program.timeLeft = 600000;
        }
        private void Clear_edit(object sender, EventArgs e)
        {
            txt_edit_cod.Text = "";
            txt_edit_nom.Text = "";
            txt_edit_des.Text = "";
            cmb_edit_luogo.SelectedItem = "";
            cmb_edit_tipo.SelectedItem = "";
            list_edit_classi.Items.Clear();
            list_edit_mat.Items.Clear();

            pan_edit.Enabled = false;
            pan_edit1.Enabled = false;
        }

        private void list_edit_classi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_più_edit.Enabled = false;
            btn_meno_edit.Enabled = false;

            if (list_edit_classi.SelectedIndices.Count != 1)
            {
                btn_rm_edit.Enabled = false;
                txt_selected_edit.Text = "";

                return;
            }

            txt_selected_edit.Text = list_edit_classi.SelectedItems[0].SubItems[1].Text;

            btn_rm_edit.Enabled = true;
        }
        #endregion
        #region Tab 4 Luoghi
        private void btn_luogo_ins_Click(object sender, EventArgs e)
        {
            Luogo nuovo = null;
            try
            {
                nuovo = new Luogo(txt_luo_name.Text, cmb_luo_open.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (nuovo != null)
                Program.GlobalConfig.EleLuogo.Add(nuovo);

            if (nuovo == null) return;

            cmb_ins_luogo.Items.Add(nuovo);
            cmb_filter_luogo.Items.Add(nuovo);
            cmb_edit_luogo.Items.Add(nuovo);

            list_luoghi.Items.Add(new ListViewItem(new string[] { nuovo.Code, nuovo.Nome, nuovo.Aperto}));

            Program.timeLeft = 600000;
        }
        private void list_luoghi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_luoghi.SelectedIndices.Count != 1)
                return;

            var selected = Program.GlobalConfig.EleLuogo.Where(l => l.Code == list_luoghi.SelectedItems[0].SubItems[0].Text).FirstOrDefault();

            if (selected == null) return;

            txt_luo_code.Text = selected.Code;
            txt_luo_edit.Text = selected.Nome;
            cmb_luo_edit.Text = selected.Aperto;

            pan_luo_edit.Enabled = true;
        }
        private void btn_luo_edit_Click(object sender, EventArgs e)
        {
            var selected = Program.GlobalConfig.EleLuogo.Where(l => l.Code == txt_luo_code.Text).FirstOrDefault();

            if (selected == null) return;

            selected.Nome = txt_luo_edit.Text;
            selected.Aperto = cmb_luo_edit.Text;



            btn_luo_back_Click(sender, e);
        }
        private void btn_luo_back_Click(object sender, EventArgs e)
        {
            txt_luo_code.Text = "";
            txt_luo_edit.Text = "";
            cmb_edit_luogo.Text = "Aperto";

            pan_luo_edit.Enabled = false;
        }
        #endregion
        #region Tab 5 Attività
        private void btn_att_ins_Click(object sender, EventArgs e)
        {
            Tipo nuovo = null;
            try
            {
                nuovo = new Tipo(txt_att_nm.Text, txt_att_des.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (nuovo != null)
                Program.GlobalConfig.EleTipo.Add(nuovo);

            cmb_ins_tipo.Items.Add(nuovo);
            cmb_filter_tipo.Items.Add(nuovo);
            cmb_edit_tipo.Items.Add(nuovo);

            list_attività.Items.Add(new ListViewItem(new string[] { nuovo.Code, nuovo.Nome }));

            Program.timeLeft = 600000;
        }
        private void txt_att_des_TextChanged(object sender, EventArgs e)
        {
            if (list_attività.SelectedIndices.Count != 1)
                return;

            var selected = Program.GlobalConfig.EleTipo.Where(l => l.Code == list_attività.SelectedItems[0].SubItems[0].Text).FirstOrDefault();

            if (selected == null) return;

            txt_att_code.Text = selected.Code;
            txt_att_ednom.Text = selected.Nome;
            txt_att_eddes.Text = selected.Descrizione;

            pan_att_edit.Enabled = true;

            Program.timeLeft = 600000;
        }
        private void list_attività_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_attività.SelectedIndices.Count != 1)
                return;

            var selected = Program.GlobalConfig.EleTipo.Where(l => l.Code == list_attività.SelectedItems[0].SubItems[0].Text).FirstOrDefault();

            if (selected == null) return;

            txt_att_code.Text = selected.Code;
            txt_att_ednom.Text = selected.Nome;
            txt_att_eddes.Text = selected.Descrizione;

            pan_att_edit.Enabled = true;

            Program.timeLeft = 600000;
        }
        private void btn_att_edit_Click(object sender, EventArgs e)
        {
            var selected = Program.GlobalConfig.EleTipo.Where(l => l.Code == txt_att_code.Text).FirstOrDefault();

            if (selected == null) return;

            selected.Nome = txt_att_ednom.Text;
            selected.Descrizione = txt_att_eddes.Text;

            btn_att_back_Click(sender, e);

            Program.timeLeft = 600000;
        }
        private void btn_att_back_Click(object sender, EventArgs e)
        {
            txt_att_code.Text = "";
            txt_att_ednom.Text = "";
            txt_att_eddes.Text = "";

            pan_att_edit.Enabled = false;

            Program.timeLeft = 600000;
        }
        #endregion
        #region Altro
        private void add_classe(object sender, EventArgs e)
        {
            List<string> eleInseriti = new List<string>();
            ListView list = list_classi;
            if ((sender as Button) == btn_edit_età) list = list_edit_classi;
            ComboBox cmb = cmb_ins_classe;
            if ((sender as Button) == btn_edit_età) cmb = cmb_edit_età;

            foreach (ListViewItem i in list.Items)
                eleInseriti.Add(i.SubItems[0].Text);

            if (cmb.Text == "Elementari")
            {
                if (!eleInseriti.Contains("Prima Elementare"))
                    list.Items.Add("Prima Elementare");
                if (!eleInseriti.Contains("Seconda Elementare"))
                    list.Items.Add("Seconda Elementare");
                if (!eleInseriti.Contains("Terza Elementare"))
                    list.Items.Add("Terza Elementare");
                if (!eleInseriti.Contains("Quarta Elementare"))
                    list.Items.Add("Quarta Elementare");
                if (!eleInseriti.Contains("Quinta Elementare"))
                    list.Items.Add("Quinta Elementare");
            }
            else if (cmb.Text == "Medie")
            {
                if (!eleInseriti.Contains("Prima Media"))
                    list.Items.Add("Prima Media");
                if (!eleInseriti.Contains("Seconda Media"))
                    list.Items.Add("Seconda Media");
                if (!eleInseriti.Contains("Terza Media"))
                    list.Items.Add("Terza Media");
            }
            else if (cmb.Text == "Tutti")
            {
                if (!eleInseriti.Contains("Prima Elementare"))
                    list.Items.Add("Prima Elementare");
                if (!eleInseriti.Contains("Seconda Elementare"))
                    list.Items.Add("Seconda Elementare");
                if (!eleInseriti.Contains("Terza Elementare"))
                    list.Items.Add("Terza Elementare");
                if (!eleInseriti.Contains("Quarta Elementare"))
                    list.Items.Add("Quarta Elementare");
                if (!eleInseriti.Contains("Quinta Elementare"))
                    list.Items.Add("Quinta Elementare");
                if (!eleInseriti.Contains("Prima Media"))
                    list.Items.Add("Prima Media");
                if (!eleInseriti.Contains("Seconda Media"))
                    list.Items.Add("Seconda Media");
                if (!eleInseriti.Contains("Terza Media"))
                    list.Items.Add("Terza Media");
            }
            else if (!String.IsNullOrEmpty(cmb.Text))
                if (!eleInseriti.Contains(cmb.Text))
                    list.Items.Add(cmb.Text);

            Program.timeLeft = 600000;
        }

        private void CheckIfStop()
        {
            System.Windows.Forms.Timer tmStop = new System.Windows.Forms.Timer();
            tmStop.Interval = 1000;
            tmStop.Tick += timer_tick;
            tmStop.Enabled = true;
            while (true)
            {
                Application.DoEvents();
            }

        }

        private void timer_tick(object sender, EventArgs e)
        {

            Program.timeLeft -= 1000;

            if (Program.timeLeft <= 0)
            {
                this.Close();
            }

            lbl_time.Text = "Tempo rimasto: " + Math.Floor((decimal)Program.timeLeft / 60000) + ":" + ((Program.timeLeft % 60000) / 1000).ToString("00");
        }


        #endregion

        private void itm_save_Click(object sender, EventArgs e)
        {
            Program.GlobalConfig.WriteToFile();
        }

        private void itm_savcn_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Contains("Utenti") ? "\\Documenti" : "\\Documents");
            fileDialog.Title = $"Salva con nome";
            fileDialog.AddExtension = true;
            fileDialog.FileName = $"Archivio {DateTime.Today.ToString("dd-MM-yyyy")}";
            fileDialog.Filter = "Archivio (*.json)|*.json|File di backup (*.bak)|*.bak";
            fileDialog.DefaultExt = "json";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(fileDialog.FileName);
                Program.GlobalConfig.WriteToFile(path);
            }
        }

        private void itm_carica_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            fileDialog.Title = $"Carica";
            fileDialog.AddExtension = true;
            fileDialog.Filter = "File di backup (*.bak)|*.bak|Archivio (*.json)|*.json";
            fileDialog.DefaultExt = "bak";



            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(fileDialog.FileName);
                var tmp = Program.GlobalConfig;
                Program.GlobalConfig = GlobalConfiguration.ReadJson(path);
                tmp.WriteToFile($"backup_{DateTime.Now.ToString("yyyyMMddhhmmss")}.bak");
            }
        }

        private void tutteLeAttivitàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Contains("Utenti") ? "\\Documenti" : "\\Documents");
            fileDialog.Title = $"Esporta CSV";
            fileDialog.AddExtension = true;
            fileDialog.FileName = $"Archivio {DateTime.Today.ToString("dd-MM-yyyy")}";
            fileDialog.Filter = "File di calcolo con separatori (*.csv)|*.csv";
            fileDialog.DefaultExt = "csv";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(fileDialog.FileName);
                StreamWriter file = new StreamWriter(path);
                file.WriteLine($"Codice;Nome;Tipo;Luogo;Descrizione");
                foreach (var a in Program.GlobalConfig.EleAttivit)
                {
                    file.WriteLine($"{a.Code};{a.Nome};{a.Tipo};{a.Luogo};{a.Descrizione}");
                }
                file.Close();
                file.Dispose();
            }
        }

        private void singolaAttivitàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frm_exp()).ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Program.Ripeti = true;
            this.Close();
        }

        private void list_vis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_vis.SelectedIndices.Count <= 0 || list_vis.SelectedIndices[0] == -1)
                return;

            var cod = list_vis.SelectedItems[0].SubItems[0].Text;
            var att = Program.GlobalConfig.EleAttivit.Where(a => a.Code == cod).FirstOrDefault();
            if (att == null) return;
            //this.TopLevel = false;
            (new frm_vis_att(att) { Owner = this }).Show();
        }
    }
}
