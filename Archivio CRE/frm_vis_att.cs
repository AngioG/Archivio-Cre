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
    public partial class frm_vis_att : Form
    {
        public frm_vis_att()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public frm_vis_att(Attività att)
        {
            InitializeComponent();

            txt_nome.Text = att.Nome;
            txt_des.Text = att.Descrizione;
            txt_tipo.Text = att.Tipo.ToString();
            txt_luogo.Text = att.Luogo.ToString();

            foreach(var m in att.Materiale)
                list_materiali.Items.Add(new ListViewItem(new string[] {m.Item1.ToString(), m.Item2}));

            foreach (var e in att.Età)
                list_classi.Items.Add(new ListViewItem(new string[] { e }));
        }

        /// <summary>
        /// Uso il mouse click sulla form visto che i controlli su cui dovrei schiacciare non sono enabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_vis_att_MouseClick(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X/* - 20*/, e.Y/* - 75*/);
            //Se il click del mouse è dentro la textbox del tipo
            if (PointInControl(txt_tipo, pt))
            {
                var att = Program.GlobalConfig.EleTipo.Where(t => t.Nome == txt_tipo.Text).FirstOrDefault();
                if (att == null) return;
                (new frm_vis_tipo(att)).ShowDialog();
            }

            //Se il click del mouse è dentro la textbox del luogo
            if (PointInControl(txt_luogo, pt))
            {
                var luo = Program.GlobalConfig.EleLuogo.Where(l => l.Nome == txt_luogo.Text).FirstOrDefault();
                if (luo == null) return;
                (new frm_vis_luo(luo)).ShowDialog();
            }
        }

        private bool PointInControl(Control c, Point pt)
        {
            if (c.Location.X > pt.X || c.Location.Y > pt.Y || c.Location.X + c.Width < pt.X || c.Location.Y + c.Height < pt.Y)
                return false;

            return true;
        }
    }
}
