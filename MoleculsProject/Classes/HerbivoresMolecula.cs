

namespace Mol.Classes
{
    internal class HerbivoresMolecula : Molecula
    {
        public HerbivoresMolecula(string name, float weight) : base(name,weight)
        {
            WayOfEating = new Herbivores();
        }

    }
}
