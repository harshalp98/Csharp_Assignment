using System;

namespace ENum_ex
{

    enum  Days{
        Mon,Tue,Wed,Thu,Fri,Sat,Sun
    }

  
    internal class Program
    {
        public static void printDay(Days d)
        {
            Console.WriteLine(d);

        }
        static void Main(string[] args)
        {
          printDay(Days.Tue);
            Console.ReadKey();
        }
    }
}
