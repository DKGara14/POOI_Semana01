using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinador cordinador = new Coordinador();
            cordinador.nombre = "Daisuke";
            cordinador.codigo = 01;
            cordinador.categoria = 0;
            cordinador.numCelular = 998222333;

            Console.WriteLine("Nombre: " + cordinador.nombre);
            Console.WriteLine("Codigo: " + cordinador.codigo);
            Console.WriteLine("Categoria: " + cordinador.categoria);
            Console.WriteLine("Numero de celular: " + cordinador.numCelular);
            Console.WriteLine("Saldo del cordinador: " + cordinador.sueldo());

            Console.ReadKey();
        }
        }
    }


