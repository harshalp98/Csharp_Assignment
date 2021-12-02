using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationEx
{
    [Serializable]
    class Employee {
        int id;
        //[NonSerialized] is used to avoid serialization of seperate data member
        string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return "Id:" + id + " Name:" + name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(101,"Alex");
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                //serialize
                /*fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\Emp.data", FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, e);
                Console.WriteLine("Object Serialized");*/

                //deserialize
                fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\Emp.data", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                bf = new BinaryFormatter();
                Employee obj = (Employee)bf.Deserialize(fs);
                Console.WriteLine("Object Deserialized");
                Console.WriteLine(obj);

            }
            catch (IOException i)
            {
                Console.WriteLine(i.Message);
            }
            finally {
                fs.Close();
            }
            Console.ReadKey();
        }
    }
}
