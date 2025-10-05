using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Dog : Animal
    {
        // Declare constructor for Dog class
        public Dog(string name, int age, int weight, int speed) : base(name, age, weight, speed)
        {
            Species = "Canis lupus familiaris";
            Diet = new DogFood().Name;
            Hunger = 20;
        }
        // Implementation of MakeSound method
        public override void MakeSound()
        {
            System.Console.WriteLine("woof");
        }
    }
}