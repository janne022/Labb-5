using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    // Abstract class for food that animals can eat.
    public abstract class Food
    {
        public string? Name { get; set; }
        public int Saturation { get; set; }
    }
}