using System;
using System.Collections.Generic;
namespace CollectionEx2
{
    
    class Student
    {
         int rollno;
         string name;
         string course;

        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }
        public override string ToString()
        {
            return "RollNo:" + rollno + " Name:" + name + " Course:" + course;
        }
        static void Main(string[] args)
        {
            //Generic
            Dictionary<int,Student>s=new Dictionary<int, Student>();

            Console.WriteLine("Enter student details");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter rollno");
                int rn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                string n = Console.ReadLine();
                Console.WriteLine("Enter course");
                string c = Console.ReadLine();
                s.Add(rn, new Student(rn, n, c));
            }

            foreach (KeyValuePair<int, Student> st in s)
            { 
                Console.WriteLine(st.Key+" "+st.Value);
            }

            Console.ReadKey();
        }
    }
}
