using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public abstract class Animal(string name, int age, int weight, int speed)
    {
        public string? Name { get; set; } = name;
        public int Age { get; set; } = age;
        public int Weight { get; set; } = weight;
        public string ?Species { get; protected set; }
        public string ?Diet { get; protected set; }
        public int Speed { get; set; } = speed;
        public int Hunger { get; protected set; } = 20;

        // Abstract method that must be implemented and makes animal sound
        public abstract void MakeSound();
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Age: {Age}\nWeight:{Weight}\nSpecies:{Species}\nDiet:{Diet}\nSpeed:{Speed}");
        }
        public static void Sleep()
        {
            System.Console.WriteLine("Sleeping");
        }
        // Method for eating food, checks if food matches diet, can't go below 0 hunger
        public void Eat(Food food)
        {
            if (food.Name?.Equals(Diet) == true)
            {
                Hunger = Math.Max(0, Hunger - food.Saturation);
            }
            else
            {
                System.Console.WriteLine($"{Name} spits out {food.Name}!");
            }
        }
    }
}