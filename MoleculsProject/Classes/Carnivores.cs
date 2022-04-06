using Mol.Interfaces;
using System;

namespace Mol.Classes
{
    internal class Carnivores : IWayOfEating
    {
        public void Eat(Molecula thisMolecula)
        {
            Console.WriteLine($"This molecula {thisMolecula.Name} can eat other moleculs");
        }
    }
}
