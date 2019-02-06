using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0502
{
    class Dog : Animal
    {

        public string favoriteFood;

        public Dog(string name, string favoriteFood) : base(name)
        {
            this.favoriteFood = favoriteFood;
        }

        public override void MakeSound()
        {
            this.Bark();
        }

        public virtual void Bark()
        {
            Console.WriteLine("Haw haw haw");
        }

        public override string ToString()
        {
            return $"Dog Food : {this.favoriteFood} {base.ToString()}";
        }
    }
}
