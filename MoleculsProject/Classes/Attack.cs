using Mol.Interfaces;
namespace Mol.Classes
{
    class Attack : IAtack
    {
        public void Action(Molecula target, Molecula thisMolecula)
        {
            if (thisMolecula.WayOfEating.GetType() == typeof(Carnivores))
            {
                if (target.Weight < thisMolecula.Weight)
                {
                    System.Console.WriteLine($"{thisMolecula.Name} atack {target.Name}");
                    thisMolecula.WayOfEating.Eat(thisMolecula);
                    thisMolecula = thisMolecula * target;
                }
                else
                {
                    thisMolecula.Mover.Move(10f);
                }
            }
            else
            {
                if (target.Weight < thisMolecula.Weight)
                {
                    thisMolecula.WayOfEating.Eat(thisMolecula);
                }
                else
                {
                    thisMolecula.Mover.Move(10f);
                }
            }
        }
    }
}
