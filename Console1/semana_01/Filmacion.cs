using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_01
{
    internal class Filmacion
    {
        public int codigo { set; get; }
        public string titulo { set; get; }
        public int duracion { set; get; }
        public double precioSoles { set; get; }

        public double precioDolares()
        {
            return precioSoles * 3.59;
        }

    }
}
