using System;

namespace ParamArrayEx
{
    internal class Program
    {
        public int findAvg(params int[] arr)
        { 
            int sum = 0;
            for (int i=0;i<arr.Length;i++)
            { 
                sum=sum+arr[i];
            }
            int avg;
            avg= sum/arr.Length;
            return avg;
        }

        static void Main(string[] args)
        {

            Program p= new Program();
            int x=p.findAvg(1,2,3,4,5,8,9,7,8,9);
            Console.WriteLine("Average:"+x);
            Console.ReadKey();
        }
    }
}
