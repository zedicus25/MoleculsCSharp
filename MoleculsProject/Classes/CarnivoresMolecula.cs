
namespace Mol.Classes
{
    internal class CarnivoresMolecula : Molecula
    {
        public CarnivoresMolecula() : base("CarnivoresMol",15.0f)
        {
            WayOfEating = new Carnivores();
        }
    }
}
