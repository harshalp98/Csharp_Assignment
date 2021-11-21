using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class NoOfDayInMnth
    {

        public static void monthDay()
        {
            Console.WriteLine("Enter month number");
            int monthNo = Convert.ToInt32(Console.ReadLine());

            switch (monthNo) { 
            
            case 1:
                    Console.WriteLine("31");
                    break;
            case 2:
                    Console.WriteLine("28");
                    break;
            case 3:
                    Console.WriteLine("31");
                    break;
            case 4:
                    Console.WriteLine("30");
                    break;
            case 5:
                    Console.WriteLine("31");
                    break;
            case 6:
                    Console.WriteLine("30");
                    break;
            case 7:
                    Console.WriteLine("31");
                    break;
            case 8:
                    Console.WriteLine("30");
                    break;
            case 9:
                    Console.WriteLine("31");
                    break;
            case 10:
                    Console.WriteLine("30");
                    break;
            case 11:
                    Console.WriteLine("31");
                    break;
            case 12:
                    Console.WriteLine("30");
                    break;
            default:
                    Console.WriteLine("Invalid number enter");
                    break ;


            }
            Console.ReadKey();
        }
    }
}
