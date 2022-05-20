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
    public partial class frm_vis_luo : Form
    {
        public frm_vis_luo()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public frm_vis_luo(Luogo luo)
        {
            InitializeComponent();

            txt_nome.Text = luo.Nome;
            txt_tipo.Text = luo.Aperto;
        }
    }
}
