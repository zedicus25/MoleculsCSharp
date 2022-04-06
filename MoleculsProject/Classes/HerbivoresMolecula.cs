

namespace Mol.Classes
{
    internal class HerbivoresMolecula : Molecula
    {
        public HerbivoresMolecula() : base("HerbivoresMolecula",2.0f)
        {
            WayOfEating = new Herbivores();
        }
    }
}
