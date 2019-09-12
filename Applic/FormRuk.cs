using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applic
{
    public partial class FormRuk : Form
    {
        public FormRuk()
        {
            InitializeComponent();
        }

        private void пользователиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPolz f = new FormPolz();
            f.Show();
        }

        private void тканиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSprTkan f = new FormSprTkan();
            f.Show();
        }
    }
}
