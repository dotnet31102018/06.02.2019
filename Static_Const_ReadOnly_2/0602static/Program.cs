using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0602static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing please wait 4 seconds...");

            MobilePhone m1 = new MobilePhone("m1");
            Thread.Sleep(1250);
            MobilePhone m2 = new MobilePhone("m2");
            Thread.Sleep(1250);
            MobilePhone m3 = new MobilePhone("m3");
            Thread.Sleep(1250);

            MobilePhone.PrintNumberOfInstances();

            m1.PrintCreationTime();
            m2.PrintCreationTime();
            m3.PrintCreationTime();

            MobilePhone.PrintMaxPhoneSize();
        }



    }
}
