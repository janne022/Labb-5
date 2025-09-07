using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arv
{
    public abstract class Food
    {
        public string ?Name { get; set; }
        public int Saturation { get; set; }
    }
}