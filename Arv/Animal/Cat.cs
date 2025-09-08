using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Cat : Animal
    {
        // Defines properties and constructor for Cat class
        private bool _isLitterBoxTrained;
        public Cat(int age, int weight, int speed, bool isLitterBoxTrained)
        {
            Age = age;
            Weight = weight;
            Species = "Felidae";
            Diet = "Canned Tuna";
            Speed = speed;
            _isLitterBoxTrained = isLitterBoxTrained;
            Hunger = 20;
        }
        public static void Purr()
        {
            System.Console.WriteLine("prrrrrrr");
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("meow");
        }
    }
}