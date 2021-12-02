using System;
using System.Xml.Serialization;
using System.IO;

namespace XMLSerializationEx
{
    //in xml serialization the class and data members must be public.
    //class consist 1 default constructor
    [Serializable]
    public class Employee {
        public int eid;
        public string name;
        public double salary;
        public Employee() { }
        public Employee(int eid,string name,double salary)
        {
            this.eid = eid;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return "EmpId:" + eid + " Ename:" + name + " Salary:Rs." + salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            XmlSerializer s = null;
            try
            {
                //serialization
                Employee e = new Employee(101, "Alex", 25000.00);
                fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\Employee.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                s = new XmlSerializer(typeof(Employee));
                s.Serialize(fs, e);
                Console.WriteLine("Object is Serialized");

                //Deserialization
                /* FileStream fs = new FileStream("D:\\CsharpWorkspace\\TraningPractice\\Employee.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                 XmlSerializer s = new XmlSerializer(typeof(Employee));
                 Employee obj = (Employee)s.Deserialize(fs);
                 Console.WriteLine("Object is Deserialized");
                 Console.WriteLine(obj);*/
            }
            catch (IOException i)
            {
                Console.WriteLine(i.Message);
            }
            Console.ReadKey();
        }
    }
}
