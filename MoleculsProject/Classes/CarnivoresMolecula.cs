
namespace Mol.Classes
{
    internal class CarnivoresMolecula : Molecula
    {
        public CarnivoresMolecula(string name, float weight) : base(name, weight)
        {
            WayOfEating = new Carnivores();
        }
    }
}
