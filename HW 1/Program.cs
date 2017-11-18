using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        public static string strNmae { get; private set; }
        
        private static int num1;
        private static int num2;
      
      

       

        static void Main(string[] args)
        {


         


            //parmot users Name
           

            //prompt user for hitnumber

            Console.WriteLine("Enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            //promt number for bat
            Console.WriteLine("Enter a number");
            num2 = Convert.ToInt32(Console.ReadLine()); 

         //open results
            Console.WriteLine(value:num1 + "+ "+ num2 +" = " + (num1 + num2));
            Console.ReadLine();


          //subtract result
            Console.WriteLine(value:num1 + " - "  + num2 + " = " + (num1 - num2));
            Console.ReadLine();

          //multiplying result
            Console.WriteLine(value:num1 + " * " + num2 + " = " + (num1 * num2));
            Console.ReadLine();

            // divide result
            Console.WriteLine(value: num1 + "/ " + num2 + " = " + (num1 / num2));
            Console.ReadLine();



















        }
    }
   
}
