using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_2
{
    internal class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public double estatura { get; set; }
        public double peso { get; set; }

        public bool EsAdulto()
        {
            return edad >= 18;
        }

        public int IMC()
        {
            int result = 0;
            double imc = peso / (estatura * estatura);
            result = (int)imc;
            return result;
        }
    }
}
