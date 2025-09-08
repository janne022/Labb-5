using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public class Chameleon : Animal
    {
        private Color _color;
        public Chameleon(int age, int weight, int speed)
        {
            Age = age;
            Weight = weight;
            Species = "Chamaeleonidae";
            Diet = "Bugs";
            Speed = speed;
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