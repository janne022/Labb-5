using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Dog : Animal
    {

        public Dog(int age, int weight, int speed)
        {
            Age = age;
            Weight = weight;
            Species = "Canis lupus familiaris";
            Diet = "Dog Food";
            Speed = speed;
            Hunger = 20;
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("woof");
        }
    }
}