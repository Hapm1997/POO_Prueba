using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Gato : Animal_Domestico 
    {
        public override string comunicarsse()
        {
            return "Miau ... Miau ...";
        }
    }
}
