using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal_Domestico d1 = new Animal_Domestico();
            d1.Nombre = "PEPE";
            Gato g1 = new Gato();
            g1.Nombre = "Botas";
            Perro p1 = new Perro();
            p1.Nombre = "Ayvar";
            
            Console.WriteLine(g1.comunicarsse());
            Console.WriteLine(p1.comunicarsse());

            Console.WriteLine("");
            
            List<Animal> animales = new List<Animal>();
            animales.Add(g1);
            animales.Add(new Pez());
            animales.Add(new Tigre());
            animales.Add(new Perro());
            animales.Add(new Canario());
            animales.Add(p1);
            animales.Add(new Aguila());
            animales.Add(new Gato());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarsse());
            }

            Console.WriteLine("");

            List<Flyable> list_voladores = new List<Flyable>(); 
            list_voladores.Add(new Canario());
            list_voladores.Add(new Aguila());
            foreach (Flyable item in list_voladores)
            {
                Console.WriteLine(item.volar());
            }


            Console.ReadKey();
        }
    }
}
