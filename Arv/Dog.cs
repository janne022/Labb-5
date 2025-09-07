using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Dog : Animal
    {

        public Dog(int age, int weight, string species, string diet, int speed)
        {
            Age = age;
            Weight = weight;
            Species = species;
            Diet = diet;
            Speed = speed;
            Hunger = 20;
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("woof");
        }
    }
}