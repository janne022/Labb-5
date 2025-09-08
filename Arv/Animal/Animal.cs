using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public abstract class Animal
    {
        protected string ?Name { get; set; }
        protected int Age { get; set; }
        protected int Weight { get; set; }
        protected string ?Species { get; set; }
        protected string ?Diet { get; set; }
        protected int Speed { get; set; }

        public int Hunger { get; set; } = 20;

        public abstract void MakeSound();
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Age: {Age}\nWeight:{Weight}\nSpecies:{Species}\nDiet:{Diet}\nSpeed:{Speed}");
        }
        public static void Sleep()
        {
            System.Console.WriteLine("Sleeping");
        }
        //TODO: Set base hunger from Animal and then use a thread to tick up food. Make it so that hunger can't go below 0
        public void Eat(Food food)
        {
            if (food.Name != null && food.Name.Equals(Diet))
            {
                Hunger -= food.Saturation;
            }
            else
            {
                System.Console.WriteLine($"{Name} spits out {food.Name}!");
            }
        }
    }
}