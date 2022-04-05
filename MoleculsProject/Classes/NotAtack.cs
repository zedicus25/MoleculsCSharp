using Mol.Interfaces;

namespace Mol.Classes
{
    class NotAtack : IAtack
    {
        public void Action(Molecula target, Molecula thisMolecula)
        {
            throw new System.NotImplementedException();
        }
    }
}
