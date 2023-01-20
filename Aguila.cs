using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Aguila : Animal_Salvaje, Flyable
    {
        public string volar()
        {
            return "Vuelo como un Aguila";
        }
    }
}
