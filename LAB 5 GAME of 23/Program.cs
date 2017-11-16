using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5_GAME_of_23
{
    class Program
    {
        static void Main(string[] args)

        {
            string strplayAgain;
            do
            {
                int nToothpicks = 23;
                int nUserpick; int nCpuPick = 0;


                //Game instruction
                Console.WriteLine("```Game of 23````");
                Console.WriteLine("pick either 1,2, or 3 toothpicks from the pile.");
                Console.WriteLine("I will pick after you. last unintelligent entry to draw a toothpick looses");

                do
                {

                    // display my toothpicks
                    for (int i = 0; i < nToothpicks; i++)
                    {
                        if (i % 4 == 0)
                        {
                            Console.Write("|");

                        }
                        else if (i % 4 == 1)
                        {
                            Console.Write("/");


                        }
                        else if (i % 4 == 2)
                        {
                            Console.Write("_");

                        }
                        else
                        {
                            Console.Write("\\");
                        }
                    }

                    Console.WriteLine("Pick 1, 2, or 3 toothpicks");
                    while (!int.TryParse(Console.ReadLine(), out nUserpick) || (nUserpick < 1 || nUserpick > 3))
                    {

                        Console.WriteLine("not a valid entry. Must be a number.");
                        Console.WriteLine("pick 1,2, or 3 toothpicks");
                    }
                    nToothpicks -= nUserpick;

                    //computer's choice

                    if (nToothpicks > 4)
                    {
                        nCpuPick = 4 - nUserpick;
                    }
                    else if (nToothpicks > 1 && nToothpicks < 4)
                    {
                        nCpuPick = nToothpicks - 1;
                        nCpuPick += 1;
                    }
                    else if (nToothpicks==1)


                    Console.WriteLine("I Pick" + nCpuPick +" you win!!");
                

            } while (nToothpicks > 1);

            Console.WriteLine("Do you want to play again? Type Y for yes.");
           strplayAgain = Console.ReadLine();

        }while (strplayAgain=="Y" || strplayAgain=="y");


        }
    }
}

