using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parcial2V2
{
    public partial class AgregarPartidos : Form
    {
        List<Equipos> equipo = new List<Equipos>();
        List<Partidos> partido = new List<Partidos>();
        public AgregarPartidos()
        {
            InitializeComponent();
        }

        private void AgregarPartidos_Load(object sender, EventArgs e)
        {
            FileStream stream1 = new FileStream("Equipos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream1);

            while (reader.Peek() > -1)
            {
                Equipos temp = new Equipos();
                temp.Nombre = reader.ReadLine();
                temp.Ciudad = reader.ReadLine();
                temp.Fecha = Convert.ToDateTime(reader.ReadLine());
                listLocal.Items.Add(temp.Nombre);
                listVisit.Items.Add(temp.Nombre);

                equipo.Add(temp);
            }
            reader.Close();

            FileStream stream3 = new FileStream("Partidos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(stream3);

            while (reader3.Peek() > -1)
            {
                Partidos tempa = new Partidos();
                tempa.Local = reader3.ReadLine();
                tempa.Gollocal = Convert.ToInt32(reader3.ReadLine()) ;
                tempa.Visitante = reader3.ReadLine();
                tempa.Golvisitante = Convert.ToInt32(reader3.ReadLine());

                partido.Add(tempa);

            }
            reader3.Close();
        }

        private void btnPartido_Click(object sender, EventArgs e)
        {
            Partidos tempo = new Partidos();

            tempo.Local = listLocal.SelectedItem.ToString();
            tempo.Gollocal = Convert.ToInt32(gollocal.Text);
            tempo.Visitante = listVisit.SelectedItem.ToString();
            tempo.Golvisitante = Convert.ToInt32(golvisit.Text);

            partido.Add(tempo);

            FileStream stream2 = new FileStream("Partidos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer2 = new StreamWriter(stream2);

            foreach(var s in partido)
            {
                writer2.WriteLine(s.Local);
                writer2.WriteLine(s.Gollocal);
                writer2.WriteLine(s.Visitante);
                writer2.WriteLine(s.Golvisitante);
            }
            writer2.Close();

            listLocal.Text = null;
            listVisit.Text = null;

            gollocal.Text = null;
            golvisit.Text = null;
        }
    }
}
