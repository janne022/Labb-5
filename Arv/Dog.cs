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
            _age = age;
            _weight = weight;
            _species = species;
            _diet = diet;
            _speed = speed;
            _hunger = 20;
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("woof");
        }
    }
}