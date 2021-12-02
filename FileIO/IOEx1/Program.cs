using System;
using System.IO;

namespace IOEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("D:\\CsharpWorkspace\\Dr");

            if (di.Exists)
            {
                Console.WriteLine(di.FullName);
                Console.WriteLine(di.CreationTime);

            }
            else
            { 
                di.Create();
                Console.WriteLine("created");
            }
            
        }
    }
}
