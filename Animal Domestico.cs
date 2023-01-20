using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Animal_Domestico : Animal
    {
        public string Nombre { get; set; }
        public override string ToString()
        {
            return "Animal Doméstico: "+ Nombre;
        }
    }
}
