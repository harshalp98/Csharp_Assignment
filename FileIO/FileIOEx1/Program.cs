using System;
using System.IO;
namespace FileIOEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            //to write data into file
            /*try
            {
                FileStream fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\demo1.dat", FileMode.Create, FileAccess.Write);

                for (int i = 0; i < 5; i++)
                {
                    fs.WriteByte((byte)i);
                }
                fs.Close();
                Console.WriteLine("Data copied into the file");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        //------------------------------------------------------------------------------------------
            //to read data from file
            try
            {
                FileStream fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\demo1.dat", FileMode.Open, FileAccess.Read);
                fs.Position = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine((int)fs.ReadByte());
                }
                fs.Close();
                //fs.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
