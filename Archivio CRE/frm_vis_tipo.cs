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
    public partial class frm_vis_tipo : Form
    {
        public frm_vis_tipo()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public frm_vis_tipo(Tipo tipo)
        {
            InitializeComponent();

            txt_nome.Text = tipo.Nome;
            txt_des.Text = tipo.Descrizione;
        }
    }
}
