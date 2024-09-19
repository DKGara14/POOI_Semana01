using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            per.nombre = "Daisuke";
            per.apellido = "Kamigashima";
            per.edad = 18;
            per.peso = 65;
            per.estatura = 1.70;

            Console.WriteLine("Nombre: " + per.nombre);
            Console.WriteLine("Apellido: " + per.apellido);
            Console.WriteLine("Edad: " + per.edad);
            Console.WriteLine("Estatura: " + per.estatura);
            Console.WriteLine("Peso: " + per.peso);
            if (per.EsAdulto())
            {
                Console.WriteLine(per.nombre + " es adulto");
            }
            else
            {
                Console.WriteLine(per.nombre + " no es adulto");
            }
            Console.WriteLine("Indice de masa corporal: " + per.IMC());

            Console.ReadKey();
        }
    }
}
