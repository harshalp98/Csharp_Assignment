using System;

namespace AbstractEx
{

    abstract class Account {

        public abstract void calculateInterest(double amount);
    }
    class Saving : Account {
        public override void calculateInterest(double amount) {
            double interest = amount * .12;
            Console.WriteLine("Interest of 1 yr for Saving Acc is:Rs." + interest);
        }
    }
    class Current : Account {
        public override void calculateInterest(double amount)
        {
            double interest =amount * .12;
            Console.WriteLine("Interest of 1 yr for Current Acc is:Rs."+interest);
        }
    }
    class FDAccount : Account {
        public override void calculateInterest(double amount)
        {
            double interest =amount * .14;
            Console.WriteLine("Interest of 1 yr for FD Acc is:Rs." + interest);
        }
    }
    internal class Program
    {
        public void findInterest(Account a,double amount)
        { 
            a.calculateInterest(amount);
        }
        static void Main(string[] args)
        {
            Program p=new Program();   

            Saving s=new Saving();
            Current c = new Current();
            FDAccount fda = new FDAccount();

            p.findInterest(s, 25000.200);
            p.findInterest(c, 125000.00);
            p.findInterest(fda, 225000.800);
            Console.ReadKey();
        }
    }
}
