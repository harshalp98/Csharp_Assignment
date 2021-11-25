using System;

namespace GenericClassEx
{
    internal class GenericClass
    {

        public static void swap<T>(ref T x,ref T y)
        { 
            T temp = x;
            x = y; 
            y = temp;
        }
        static void Main(string[] args)
        {
            int a=10,b=20;
            char c = 'h', d = 'p';
            Console.WriteLine("Data before swaping");
            Console.WriteLine(a + " " + b);
            Console.WriteLine(c + " " + d);
            swap<int>(ref a,ref b);
            swap<char>(ref c,ref d);

            Console.WriteLine("Data after swaping");
            Console.WriteLine(a + " " + b);
            Console.WriteLine(c + " " + d);
            Console.ReadKey();
        }
    }
}
