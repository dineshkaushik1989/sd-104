using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {

            int F0 = 0;
            int Secondprev = 0;
            int Prev = 1;
            int current, fibnum = 1;

            Console.WriteLine("which fib number you wants to see");
            fibnum =Convert.ToInt32( Console.ReadLine());
            
            for (int i = 0; i < fibnum; i++)
            {
                current = Prev + Secondprev;
                Secondprev = Prev;
                Prev = current;

            }
            Console.WriteLine(Prev);
            Console.ReadLine();


        }

    }
}
