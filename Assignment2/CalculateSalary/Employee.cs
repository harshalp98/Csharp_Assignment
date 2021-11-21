using System;

namespace CalculateSalary
{
    internal class Employee
    {

        int empId;
        string empName;
        string desg;

        public Employee(int empId, string empName, string desg)
        { 
            this.empId = empId;
            this.empName = empName; 
            this.desg = desg;
        }
        public void printData()
        {
            Console.WriteLine("EmpId:" + empId + " EmpName:" + empName + " Designation:" + desg);
        }
        static void Main(string[] args)
        {
            PermanentEmployee emp = new PermanentEmployee(101,"Harsh","SE",15000.00);
            emp.PrintData();
            Console.ReadKey();
        }
    }
    class PermanentEmployee : Employee {
        double basicSalary;
        public PermanentEmployee(int empId, string empName, string desg, double basicsalary):base(empId, empName, desg)
        { 
            this.basicSalary = basicsalary;
        }
        public void PrintData()
        { 
            base.printData();
            double hra = basicSalary + (basicSalary * .50);
            double da = basicSalary + (basicSalary * .50);
            double grossSal = basicSalary + hra + da;
            Console.WriteLine(grossSal);
        }
    }
}
