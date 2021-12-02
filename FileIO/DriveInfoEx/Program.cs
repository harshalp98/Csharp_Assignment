using System;
using System.IO;

namespace DriveInfoEx
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo d = new DriveInfo("D:\\");
            Console.WriteLine(d.DriveFormat);
            Console.WriteLine(d.Name); 
            Console.WriteLine(d.AvailableFreeSpace);

            Console.WriteLine(Path.GetFileName("D:\\CsharpWorkspace\\TrainingPractice\\DriveInfoEx\\Program.cs"));
            Console.WriteLine(Path.GetExtension("D:\\CsharpWorkspace\\TrainingPractice\\DriveInfoEx\\Program.cs"));
            Console.ReadKey();
        }
    }
}
