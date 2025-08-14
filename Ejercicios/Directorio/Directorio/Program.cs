using Directorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Directorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Marcador marcador = new Marcador();


            string nombreCompleto = string.Empty;   

            persona.setNombre("Pedro Antonio");
            persona.setApellidos("Perez Perez");

            nombreCompleto = persona.getNombreCompleto();
            Console.WriteLine("Persona 1" + " " + nombreCompleto + " " + "Salario: "  + marcador.getSalario(44*4));

            nombreCompleto = persona.getNombreCompleto("Jose Cecilio ", "Del Valle");

            Console.WriteLine("Persona 2" + " " + nombreCompleto + " " + "Salario: "  + marcador.getSalario(35*4));

            Console.ReadLine();
        }
    }
}
