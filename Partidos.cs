using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2V2
{
    class Partidos
    {
        String local;
        int gollocal;
        String visitante;
        int golvisitante;

        public string Local { get => local; set => local = value; }
        public int Gollocal { get => gollocal; set => gollocal = value; }
        public string Visitante { get => visitante; set => visitante = value; }
        public int Golvisitante { get => golvisitante; set => golvisitante = value; }
    }
}
