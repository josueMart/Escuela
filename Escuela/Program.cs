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
            var alumno1 = new Alumno("Juan Carlos", "Ruiz") { Id = 1, Edad = 36, Telefono = "4491648332", Email = "josue.mart@live.com.mx" };
            var persona1=new Persona() {Id = 1, Nombre = "Freddy", Apellido = "Vega", Edad = 56, Telefono = "568945565"};
            var profesor = new Profesor() { Id = 1, Nombre = "Freddy", Apellido = "Vega", Edad = 56, Telefono = "568945565", Catedra="Programacion"};
            Console.WriteLine(Persona.ContadorPersonas);
            Console.ReadLine();
        }
    }
}
