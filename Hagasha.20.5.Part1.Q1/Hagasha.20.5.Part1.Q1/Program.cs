using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagasha._20._5.Part1.Q1
{
    class Program
    {

        private static void Power2(ref int i)
        {
            i = i * i;


        }
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Enter a number:");
             x = Convert.ToInt32(Console.ReadLine());
            Power2(ref x);
            Console.WriteLine($"power 2 of your number is {x}");
            Console.ReadLine();
        }
       

    }
}
