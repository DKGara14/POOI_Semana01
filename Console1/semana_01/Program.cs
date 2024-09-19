using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filmacion doc = new Filmacion();
            doc.codigo = 001;
            doc.titulo = "Divertidamente";
            doc.duracion = 180;
            doc.precioSoles = 10;

            Console.WriteLine("Codigo: " + doc.codigo);
            Console.WriteLine("Titulo: " + doc.titulo);
            Console.WriteLine("Duracion de la pelicula en Min: " + doc.duracion);
            Console.WriteLine("Precio en Soles: " + doc.precioSoles);
            Console.WriteLine("precio en Dolares: " + doc.precioDolares());

            Console.ReadKey();


    }
}
}
