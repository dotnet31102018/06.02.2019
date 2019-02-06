using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0502
{
    class PetWolf : Wolf
    {
        public PetWolf(string name, string favoriteFood, string nameOfPack) : base(name, favoriteFood, nameOfPack)
        {
        }

        public override void Bark()
        {
            Console.WriteLine("miaw miaw");
        }

        public override string ToString()
        {
            return $"Pet wolf {base.ToString()}";
        }
    }
}
