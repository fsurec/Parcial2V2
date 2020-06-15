using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregaEquipo nuevo = new AgregaEquipo();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void partidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPartidos nuevo1 = new AgregarPartidos();
            nuevo1.MdiParent = this;
            nuevo1.Show();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResumenResultados nuevo = new ResumenResultados();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}
