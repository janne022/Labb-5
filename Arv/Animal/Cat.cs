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
        public Cat(string name, int age, int weight, int speed, bool isLitterBoxTrained) : base(name, age, weight, speed)
        {
            Species = "Felidae";
            Diet = new CannedTuna().Name;
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