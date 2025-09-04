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
            _age = age;
            _weight = weight;
            _species = species;
            _diet = diet;
            _speed = speed;
            _hunger = 20;
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