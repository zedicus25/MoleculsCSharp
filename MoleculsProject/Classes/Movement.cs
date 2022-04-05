using Mol.Interfaces;
namespace Mol.Classes
{
    internal class Movement : IMove
    {
        public void Move(float speed)
        {
            System.Console.WriteLine($"Move up with speed {speed}");
        }
    }
}
