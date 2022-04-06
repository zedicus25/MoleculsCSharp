using Mol.Interfaces;
using System;
namespace Mol.Classes
{
    class Molecula
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public IMove Mover { get; set; }
        public IAtack Atack { get; set; }
        public IWayOfEating WayOfEating { get; set; }
        public Molecula() : this("Default",1.0f)
        {
            
        }
        public Molecula(string name, float weight)
        {
            Mover = new Movement();
            Atack = new Attack();
            Name = name;  
            Weight = weight;   
        }

        public Molecula Division()
        {
            if (Weight > 5.0f)
            {
                Weight -= 2.0f;
                Console.WriteLine("Division succefull");
                return new Molecula("Division Molecula", 2.0f);
            }
            else
            {
                Console.WriteLine("I cant division, because i small");
                return null;
            }
        }

        public static Molecula operator + (Molecula m1, Molecula m2)
        {
            return new Molecula();
        }

        public static Molecula operator -(Molecula m1, Molecula m2)
        {
            if(m1.Weight > m2.Weight)
                return new Molecula(m1.Name+m2.Name, m1.Weight - m2.Weight);
            else
                return new Molecula(m2.Name + m1.Name, m2.Weight - m1.Weight);
        }

        public static Molecula operator *(Molecula m1, Molecula m2)
        {
            return new Molecula(m1.Name + m2.Name, m1.Weight + m2.Weight);
        }
    }      
}
