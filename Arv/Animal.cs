using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public abstract class Animal
    {
        protected int _age { get; set; }
        protected int _weight { get; set; }
        protected string ?_species { get; set; }
        protected string ?_diet { get; set; }
        protected int _speed { get; set; }

        public int _hunger { get; set; }

        public abstract void MakeSound();
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Age: {_age}\nWeight:{_weight}\nSpecies:{_species}\nDiet:{_diet}\nSpeed:{_speed}");
        }
        public void Sleep()
        {
            System.Console.WriteLine("Sleeping");
        }
        //TODO: Set base hunger from Animal and then use a thread to tick up food. Make it so that hunger can't go below 0
        public void Eat(Food food)
        {
            _hunger -= food._saturation;
        }
    }
}