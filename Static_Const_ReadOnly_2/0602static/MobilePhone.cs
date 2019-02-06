using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0602static
{
    class MobilePhone
    {
        public string name;
        public static int _numberOfInstances;
        public readonly DateTime creationTime;
        public const float MAX_PHONE_SIZE = 6.9f;
        public MobilePhone(string name)
        {
            this.name = name;
            _numberOfInstances++;
            creationTime = DateTime.Now;
        }

        public void PrintPhoneName()
        {
            Console.WriteLine($"Phone name {this.name}");
        }

        public static void PrintNumberOfInstances()
        {
            Console.WriteLine($"Number of instances : {_numberOfInstances}");
        }

        public static void PrintMaxPhoneSize()
        {
            Console.WriteLine($"Maximum phone size : {MAX_PHONE_SIZE}");
        }

        public void PrintCreationTime()
        {
            Console.WriteLine($"Creation time : {this.creationTime}");
        }

    }
}
