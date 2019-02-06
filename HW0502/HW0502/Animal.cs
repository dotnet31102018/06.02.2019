using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0502
{
    abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"Animal {this.name}";
        }
    }
}
