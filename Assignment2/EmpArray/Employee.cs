using System;

namespace EmpArray
{
    internal class Employee
    {
        int empNo1;
        string empName1;
        string designation1;
        int salary1;

        public Employee()
        {
            Console.WriteLine("Enter emp no");
            empNo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter emp name");
            empName1 = Console.ReadLine();
            Console.WriteLine("Enter emp desg");
            designation1 = Console.ReadLine();
            Console.WriteLine("Enter emp salary");
            salary1 = Convert.ToInt32(Console.ReadLine());
        }

        public static void Main(string[] args)
        { 
            Employee[] e=new Employee[10];
            for (int i=0;i<e.Length;i++)
            { 
                e[i] = new Employee();
            }

            foreach (Employee k in e)
            { 
                Console.WriteLine("EmpNo:"+k.empNo1+" EmpName:"+k.empName1+" Desg:"+k.designation1+" Salary:Rs."+k.salary1);
            }
        }

    }
}

