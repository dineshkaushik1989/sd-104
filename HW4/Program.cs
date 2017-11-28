using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {

      static  string Roman;
       static int Year;
        static void Main(string[] args)
        {
            Console.WriteLine("which roman number you want to see");
            Year = Convert.ToInt32(Console.ReadLine());

            int thousand = Year/1000;
            Year -= thousand*1000;
            int hundreds = (Year) / 100;
            Year -= hundreds*100;
            int tens = (Year) / 10;
            Year -= tens*10;
            int one = Year;

            switch (thousand)
            {

                case 3000:
                    Roman += "mmm";break;
                case 2000:
                    Roman += "mm";break;
                case 1000:
                    Roman += "m";break;
                case 900:
                    Roman += "cm";break;
                case 800:
                    Roman += "dccc"; break;
                case 700:
                    Roman += "dcc"; break;
                case 600:
                    Roman += "dc";break;
                case 500:
                    Roman += "d";break;
                case 400:
                    Roman += "cd";break;
                case 300:
                    Roman += "ccc";break;
                case 200:
                    Roman += "cc";break;
                case 100:
                    Roman += "c"; break;
                case 90:
                    Roman += "xc";break;
                case 80:
                    Roman += "lxxx";break;
                case 70:
                    Roman += "lxx";break;
                case 60:
                    Roman += "lx"; break;
                case 50:
                    Roman += "l";break;
                case 40:
                    Roman += "xl";break;
                case 30:
                    Roman += "xxx";break;
                case 20:
                    Roman += "xx";break;
                case 19:
                    Roman += "xix";break;
                case 18:
                    Roman += "xviii"; break;
                case 17:
                    Roman += "xvii"; break;
                case 16:
                    Roman += "xvi"; break;
                case 15:
                    Roman += "xv"; break;
                case 14:
                    Roman += "xiv"; break;
                case 13:
                    Roman += "xiii"; break;
                case 12:
                    Roman += "xii"; break;
                case 11:
                    Roman += "xi"; break;
                case 10:
                    Roman += "x"; break;
                case 9:
                    Roman += "ix"; break;
                case 8:
                    Roman += "viii"; break;
                    case 7:
                    Roman += "vii"; break;
                case 6:
                    Roman += "vi"; break;
                case 5:
                    Roman += "v"; break;
                case 4:
                    Roman += "iv"; break;
                case 3:
                    Roman += "iv"; break;
                case 2:
                    Roman += "ii"; break;
                case 1:
                    Roman += "i"; break;

            }

            Console.WriteLine(Roman);
            Console.ReadLine();
        }
           
    }
}
