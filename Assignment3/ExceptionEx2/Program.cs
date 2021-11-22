using System;
using System.IO;

namespace ExceptionEx2
{

      
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine("Enter num");
                    int x = Convert.ToInt32(Console.ReadLine());
                    arr[i] = x;
                }
            }
            catch (IndexOutOfRangeException e)
            { 
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
