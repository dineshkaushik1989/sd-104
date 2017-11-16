using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6parallel_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] Phone = { "555-1334", "555-3882", "555-8211", "555-1617", "555-2803" };
            string strSearch;
            bool isFound = false;
            //prompt user
            Console.WriteLine("Enter a name to search for in the phone book:");
            strSearch = Console.ReadLine();


            //loop through array looking for the name 
            for (int i = 0; i < Names.Length; i++)
            {

                if (Names[i].IndexOf(strSearch) > -1)
                {
                    Console.WriteLine(Names[i] + " ->" + Phone[i]);
                }
                isFound = true;
            }
            if (!isFound)
            {
                Console.WriteLine("Name not Found");

                Console.ReadLine();

            }

        }
    }
}








