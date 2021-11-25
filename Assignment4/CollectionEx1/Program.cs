using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionEx1
{
    class Employee { 
        int id;
        string name;

        public Employee(int id, string name)
        { 
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return "EmpId:" + id + " EmpName:" + name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> l = new List<Employee>();
            l.Add(new Employee(1, "Alex"));
            l.Add(new Employee(2, "Flex"));
            l.Add(new Employee(3, "Lily"));
            l.Add(new Employee(4, "Jhon"));
            l.Add(new Employee(5, "Pari"));

            foreach (Employee e in l)
            { 
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
