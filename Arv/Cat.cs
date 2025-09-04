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
            _age = age;
            _weight = weight;
            _species = species;
            _diet = diet;
            _speed = speed;
            _isLitterBoxTrained = isLitterBoxTrained;
            _hunger = 20;
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