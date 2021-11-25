using System;
using System.IO;

namespace FileDetailsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("D:\\CsharpWorkspace\\Demo");
            if (d.Exists)
            { 
                Console.WriteLine(d.FullName);
                Console.WriteLine(d.CreationTime);

                FileInfo[] fi = d.GetFiles();
                foreach (FileInfo f in fi)
                {
                    Console.WriteLine(f.FullName);
                    Console.WriteLine(f.Length);
                }
                Console.ReadKey();  
            }
        }
    }
}
