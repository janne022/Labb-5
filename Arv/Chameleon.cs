using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Chameleon : Animal
    {
        Color _color;
        public Chameleon(int age, int weight, string species, string diet, int speed)
        {
            Age = age;
            Weight = weight;
            Species = species;
            Diet = diet;
            Speed = speed;
            Hunger = 20;
        }
        public void ChangeColor(Color color)
        {
            _color = color;
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("hiss");
        }
    }
}