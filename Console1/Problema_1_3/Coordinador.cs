using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_3
{
    internal class Coordinador
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public int categoria { get; set; }
        public int numCelular { get; set; }

        public int sueldo()
        {
            if (categoria == 0)
            {
                return 8500;
            }
            else if (categoria == 1)
            {
                return 6850;
            }
            else 
            {
                return 5500;
            }
        }

    }
       
}
