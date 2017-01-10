using Escuela.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTION DE INSTITUCION");
            var alumno1 = new Alumno() { Id = 1, Nombre = "Juan Carlos", Apellido = "Ruiz", Edad = 36, Telefono = "4491648332", Email="josue.mart@live.com.mx"};
            var persona1=new Persona() {Id = 1, Nombre = "Freddy", Apellido = "Vega", Edad = 56, Telefono = "568945565"};

            Console.ReadLine();
        }
    }
}
