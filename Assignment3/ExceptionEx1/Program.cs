using System;
using System.IO;
namespace ExceptionEx1
{
    internal class Program
    {
        public void div()
        {
            try
            {
                Console.WriteLine("Enter two no");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int ans = a / b;
                Console.WriteLine(ans);
            }
            catch (DivideByZeroException d)
            { 
                Console.WriteLine(d.Message);
                throw d;

            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            try
            {
                p.div();
            }
            catch (Exception e)
            {
                p.div();
            }

            Console.ReadKey();
        }
    }
}
