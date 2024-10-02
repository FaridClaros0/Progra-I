using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academica
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objForm = new Form1();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias objForm = new Materias();
            objForm.MdiParent = this;
            objForm.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Docentes objForm = new Docentes();
            objForm.MdiParent = this;
            objForm.Show();
        }
    }
}
