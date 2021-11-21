using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Employee
    {
        int empNo;
        string empName;
        string designation;
        int salary;

        public void acceptDetails()
        {
            Console.WriteLine("Enter Employee No");
            empNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            empName=Console.ReadLine();
            Console.WriteLine("Enter Employee Designation");
            designation = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void showDetails()
        {
            Console.WriteLine("EmpNo:"+empNo+" Empname:"+empName+" Designation:"+designation+" salary:"+salary);
        }

    }
}
