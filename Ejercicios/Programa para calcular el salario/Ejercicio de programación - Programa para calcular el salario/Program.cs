using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_programación___Programa_para_calcular_el_salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double CostoHora = 100;
            double horasTrabajadas = 40;
            double totalDevengado = CostoHora * horasTrabajadas;

           Console.WriteLine("Las horas que se trabajaron en la semana son: " + horasTrabajadas );

           Console.WriteLine("La hora se paga en: L. " + CostoHora );

           Console.WriteLine("El salario semanal es: L. " + totalDevengado );

            Console.ReadLine();
        }
    }
}
