using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Dog : Animal
    {
        // Defines properties and constructor for Dog class

        public Dog(int age, int weight, int speed)
        {
            Age = age;
            Weight = weight;
            Species = "Canis lupus familiaris";
            Diet = new DogFood().Name;
            Speed = speed;
            Hunger = 20;
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("woof");
        }
    }
}