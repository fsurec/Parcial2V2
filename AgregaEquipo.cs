using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace Parcial2V2
{
    public partial class AgregaEquipo : Form
    {
        List<Equipos> equipo = new List<Equipos>();

        public AgregaEquipo()
        {
            InitializeComponent();
        }

        private void AgregarEquipo_Click(object sender, EventArgs e)
        {
            Equipos tempequipo = new Equipos();

            tempequipo.Nombre = txtEquipo.Text;
            tempequipo.Ciudad = txtCiudad.Text;
            tempequipo.Fecha = Convert.ToDateTime(fundacion.Value);

            equipo.Add(tempequipo);

            FileStream stream = new FileStream("Equipos.txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var p in equipo)
            {
                writer.WriteLine(p.Nombre);
                writer.WriteLine(p.Ciudad);
                writer.WriteLine(p.Fecha);

            }
            writer.Close();

            txtEquipo.Text = null;
            txtCiudad.Text = null;
            dataequipos.DataSource = null;
            dataequipos.DataSource = equipo;
            dataequipos.Refresh();


        }

        private void AgregaEquipo_Load(object sender, EventArgs e)
        {
            FileStream stream1 = new FileStream("Equipos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);

            while (reader.Peek() > -1)
            {
                Equipos temp = new Equipos();
                temp.Nombre = reader.ReadLine();
                temp.Ciudad = reader.ReadLine();
                temp.Fecha = Convert.ToDateTime(reader.ReadLine());

                equipo.Add(temp);
            }
            reader.Close();
            dataequipos.DataSource = null;
            dataequipos.DataSource = equipo;
            dataequipos.Refresh();
        }
    }
}
