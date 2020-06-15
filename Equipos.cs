using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2V2
{
    class Equipos
    {
        String nombre;
        String ciudad;
        DateTime fecha;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
