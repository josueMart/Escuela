using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Models
{
    class Persona  // sealed* para sellar la clase y que no puedan heredar de ella
    {
        public static int ContadorPersonas = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public string Telefono { get; set; }
        protected int Inasistencias { get; set; }

        public string NombreCompleto
        {
            get
            {
                return string.Format("{0} {1}", Nombre, Apellido);
            }
        }

        static Persona()
        {
            ContadorPersonas++;

        }
    }
}
