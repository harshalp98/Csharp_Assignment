using System;
using System.IO;
namespace BinaryReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //to write data in binary format

            /*FileStream fs = null;
            BinaryWriter bw = null;          
            try
            {
                fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\binary.dat", FileMode.Create, FileAccess.Write);
                bw = new BinaryWriter(fs);

                Console.WriteLine("Enter roll no");
                int r = Convert.ToInt32(Console.ReadLine());
                bw.Write(r);
                Console.WriteLine("Enter name");
                string n = Console.ReadLine();
                bw.Write(n);
                Console.WriteLine("Enter course");
                string c = Console.ReadLine();
                bw.Write(c);
                Console.WriteLine("Data added successfully");
                bw.Flush();
            }
            catch (IOException i)
            {
                Console.WriteLine(i.Message);
            }
            finally 
            {
                bw.Close();
                fs.Close();
            }*/

            //to read binary data
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\binary.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);

                Console.WriteLine("Student Info:");
                Console.WriteLine("Student Rollno:"+br.ReadInt32());
                Console.WriteLine("Student Name:"+br.ReadString());
                Console.WriteLine("Course:"+br.ReadString());
            }
            catch (IOException i)
            {
                Console.WriteLine(i.Message);
            }
            finally
            {
                br.Close();
                fs.Close();
            }
            Console.ReadKey();
        }
    }
}
