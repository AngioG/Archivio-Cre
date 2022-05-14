using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Archivio_CRE
{
    public partial class frm_exp : Form
    {
        public frm_exp()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (var a in Program.GlobalConfig.EleAttivit)
                list_src.Items.Add(new ListViewItem(new string[] { a.Code, a.Nome, a.Tipo.ToString(), a.Luogo.ToString() }));

            cmb_filter_luogo.Items.AddRange(Program.GlobalConfig.EleLuogo.ToArray());
            cmb_filter_luogo.SelectedIndex = 1;

            cmb_filter_tipo.Items.AddRange(Program.GlobalConfig.EleTipo.ToArray());
            cmb_filter_tipo.SelectedIndex = 1;

            cmb_filter_età.SelectedIndex = 8;
        }

        private void Cerca(object sender, EventArgs e)
        {
            Thread nuovo = new Thread((obj) => Cerca());
            nuovo.Name = "Esporta";
            Program.ActiveThreads.RemoveAll(t =>
            {
                if (t.Name == "Esporta")
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

            var eleFiltrato = eleCercati.Where(a => cmb_filter_luogo.SelectedIndex > 1 ? a.Luogo == cmb_filter_luogo.SelectedItem as Luogo : true || cmb_filter_tipo.SelectedIndex > 1 ? a.Tipo == cmb_filter_tipo.SelectedItem as Tipo : true ||
                                                cmb_filter_età.SelectedIndex < 8 ? a.Età.Contains(cmb_filter_età.Text) : true);


            list_src.Items.Clear();
            foreach (var a in eleCercati.ToList())
            {
                list_src.Items.Add(new ListViewItem(new string[] { a.Code, a.Nome, a.Tipo.ToString(), a.Luogo.ToString() }));
                Application.DoEvents();
            }
        }

        private void list_src_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_src.SelectedIndices.Count <= 0 || list_src.SelectedIndices[0] == -1)
                return;

            string codice = list_src.SelectedItems[0].SubItems[0].Text;
            var esporta = Program.GlobalConfig.EleAttivit.Where(a => a.Code == codice).FirstOrDefault();
            if (esporta == null)
                return;

            var dr = MessageBox.Show($"Vuoi esportare un documento contenente l'attività {esporta.Nome}?", "Conferma richiesta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
                return;

            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Contains("Utenti") ? "\\Documenti" : "\\Documents");
            fileDialog.Title = $"Esporta per Word";
            fileDialog.AddExtension = true;
            fileDialog.FileName = esporta.Nome + $" {DateTime.Today.ToString("dd-MM-yyyy")}";
            fileDialog.Filter = "File word (*.docx)|*.docx";
            fileDialog.DefaultExt = "docx";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = Path.GetFullPath(fileDialog.FileName);

                DocxManager.WriteDocx(esporta, filepath);
            }
        }
    }
}
