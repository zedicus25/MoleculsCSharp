using Mol.Interfaces;
using System;
namespace Mol.Classes
{
    internal class Herbivores : IWayOfEating
    {
        public void Eat(Molecula thisMolecula)
        {
            Console.WriteLine($"This molecula {thisMolecula.Name} eat only planktons");
            thisMolecula.Weight += 0.5f;
        }
    }
}
