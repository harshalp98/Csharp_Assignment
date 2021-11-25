using System;

namespace DateEx
{
    class Date {
        int date;
        int month;
        int year;

        public Date(int d,int m, int y) { 
            date = d;
            month = m; 
            year = y;
        }
        public override string ToString() {
            return date + "-" + month + "-" + year;
        }
        public override bool Equals(object obj)
        {
            Date d= (Date)obj;
            if(this.date==d.date && this.month==d.month && this.year==d.year)
               return true; 
            else
                return false;
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(12,10,1996);
            Date d1 = new Date(12, 10, 1996);
            Console.WriteLine(d);

            if (d.Equals(d1))
                Console.WriteLine("date obj are same");
            else
                Console.WriteLine("date obj are different");

            Console.ReadKey();
        }
    }
}
