using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Properties
    {
        int day, year, month;
        public int Day {

            set 
            {
                if (value <= 31)
                    day = value;
                else
                    Console.WriteLine("Invalid Date!!!");
            }
            get 
            { 
                return day; 
            }
        }
        public int Month
        {

            set
            {
                if (value <=12)
                    month = value;
                else
                    Console.WriteLine("Invalid month!!!");
            }
            get
            {
                return month;
            }
        }
        public int Year
        {

            set
            {
                if (value >1900)
                    year = value;
                else
                    Console.WriteLine("Invalid year!!!");
            }
            get
            {
                return year;
            }
        }

        public static void Main(string[] args)
        { 
            Properties p = new Properties();
            p.Day = 02;
            p.Month = 10;//getter called
            p.Year = 1998;
            //Console.WriteLine(p.Day+"-"+p.Month+"-"+p.Year);
            Console.WriteLine("{0}-{1}-{2}",p.Day,p.Month,p.Year);//setter called
            Console.ReadKey();
        }

    }
}
