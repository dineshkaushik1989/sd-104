using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_smallest_largest
{
    class Program
    {
        static void Main(string[] args)
        {

            //declarebvariables
            int nSmallest;
            int nlargest;
            int nCurrent;
            string strEntry;

            //first integer
            Console.Write("Enter an integer:");
            nlargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another integer or Q to Quit");
            strEntry = Console.ReadLine();

            //loop
            while(strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);

                //check to see if input shold replace largest or smallest
                if (nCurrent > nlargest)
                {
                    nlargest = nCurrent;

                }

                //prompt user
                Console.Write("Enter another integer or Q to Quit");
                strEntry = Console.ReadLine();

            }

            //print result
            Console.WriteLine("The largest value you enterd was" + nlargest);
            Console.WriteLine("The smallest value you entered was" + nSmallest);


            Console.ReadLine();






        }
    }
}
