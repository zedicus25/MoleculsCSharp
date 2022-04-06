using System;
using Mol.Classes;
namespace Mol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarnivoresMolecula carMolecula = new CarnivoresMolecula("CarMolecula",10.0f);
            HerbivoresMolecula herbMolecula = new HerbivoresMolecula("HerMolecula", 2.0f);
            Console.WriteLine(carMolecula.Weight);
            carMolecula.Atack.Action(herbMolecula, carMolecula);
            Console.WriteLine(carMolecula.Weight);

            /*CarnivoresMolecula carMolecula = new CarnivoresMolecula("CarMolecula",1.0f);
            HerbivoresMolecula herbMolecula = new HerbivoresMolecula("HerMolecula",4.0f);
            carMolecula.Atack.Action(herbMolecula, carMolecula);
            herbMolecula.Atack.Action(carMolecula, herbMolecula);*/
        }
    }
}
