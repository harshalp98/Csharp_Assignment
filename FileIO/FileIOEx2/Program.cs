using System;
using System.IO;
namespace FileIOEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            //to write data into txtfile

            //FileStream fs = null;
            //StreamWriter sw = null;
            /*try {
                fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\text1.txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                Console.WriteLine("Enter data you want to write");
                string s = "";
                while (s!=null)
                {
                    s = Console.ReadLine();
                    sw.WriteLine(s);
                }
                sw.Flush();
                Console.WriteLine("data written into the file");
                Console.ReadKey();
            }
            catch (IOException i)
            {
                Console.WriteLine(i.Message);
                fs.Close();
                sw.Close();
            }*/
            //---------------------------------------------------------------

            //to read data from txtfile

            FileStream fs = null;
            StreamReader sw = null;

            try
            {
                fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\text1.txt", FileMode.Open, FileAccess.Read);
                sw = new StreamReader(fs);

                Console.WriteLine("Data into the file is:");
                Console.WriteLine(sw.ReadToEnd());
                Console.ReadKey();
            }
            catch (IOException i)
            {
                Console.WriteLine(i.Message);
                fs.Close();
                sw.Close();
            }
        }
    }
}
