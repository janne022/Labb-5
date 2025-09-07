using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Cat : Animal
    {
        private bool _isLitterBoxTrained;
        public Cat(int age, int weight, string species, string diet, int speed, bool isLitterBoxTrained)
        {
            Age = age;
            Weight = weight;
            Species = species;
            Diet = diet;
            Speed = speed;
            _isLitterBoxTrained = isLitterBoxTrained;
            Hunger = 20;
        }
        public void Purr()
        {
            System.Console.WriteLine("prrrrrrr");
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("meow");
        }
    }
}