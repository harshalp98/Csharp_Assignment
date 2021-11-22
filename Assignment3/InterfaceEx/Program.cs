using System;

namespace InterfaceEx
{

    interface IPrintable {
        void print();
    }

    class Account : IPrintable {
        int accNo;
        string accType;
        string accHolderName;

        public Account(int accNo, string accType, string accHolderName) { 
            this.accNo = accNo;
            this.accType = accType;
            this.accHolderName = accHolderName; 
        }
        public void print() {
            Console.WriteLine("AccNo:" + accNo + " AccType:" + accType + " AccHolderName:" + accHolderName);
        }
    }

    class Employee : IPrintable {
        int eid;
        string ename;

        public Employee(int eid, string ename)
        {
            this.eid = eid;
            this.ename = ename;
        }
        public void print() { 
            Console.WriteLine("EmpId:"+eid+" EmpName:"+ename);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(321212,"Saving","Mr.Alex");
            a.print();

            Employee e = new Employee(101,"Toy");
            e.print();

            Console.ReadKey();
        }
    }
}
