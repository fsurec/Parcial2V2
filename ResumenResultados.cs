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
    public partial class ResumenResultados : Form
    {

        List<Equipos> equipo = new List<Equipos>();
        List<Partidos> partido = new List<Partidos>();
        public ResumenResultados()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ResumenResultados_Load(object sender, EventArgs e)
        {
            FileStream stream3 = new FileStream("Partidos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(stream3);

            while (reader3.Peek() > -1)
            {
                Partidos tempa = new Partidos();
                tempa.Local = reader3.ReadLine();
                tempa.Gollocal = Convert.ToInt32(reader3.ReadLine());
                tempa.Visitante = reader3.ReadLine();
                tempa.Golvisitante = Convert.ToInt32(reader3.ReadLine());

                partido.Add(tempa);

            }

           
            reader3.Close();

            dataResultados.DataSource = null;
            dataResultados.DataSource = partido;
            dataResultados.Refresh();

            int sum1, sum2, sum3;
            sum1 = partido.Sum(x => x.Gollocal);
            sum2 = partido.Sum(y => y.Golvisitante);

            sum3 = sum1 + sum2;

            totalgoles.Text = sum3.ToString();

        }
            
    }

        
}
