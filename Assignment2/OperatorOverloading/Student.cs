using System;

namespace OperatorOverloading
{
    internal class Student
    {
        int marks;
        public Student(int x)
        { 
            marks= x;
        }
        public static Student operator +(Student o1, Student o2)
        {
            Student s1 = new Student(0);
            s1.marks = o1.marks + o2.marks;
            return s1;
        }
        public static Student operator *(Student o1, Student o2)
        {
            Student s1 = new Student(0);
            s1.marks = o1.marks * o2.marks;
            return s1;
        }
        public void printData()
        {
            Console.WriteLine(marks);
        }
        static void Main(string[] args)
        {
            Student st1 = new Student(50);
            Student st2 = new Student(100);
            Student x= st1 + st2;
            x.printData();
            
            Student y= st1 * st2;
            y.printData();
            Console.ReadKey();
        }
    }
}
