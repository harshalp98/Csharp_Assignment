using System;

namespace SealedEx
{
    sealed class Parent
    {
        public virtual void print()
        {
            Console.WriteLine("Parent-Class");
        }
    }
    class Child : Parent
    {
        public sealed override void print()
        {
            Console.WriteLine("Child-Class");
        }
    }
    class GrChild : Child
    {
        public override void print()
        {
            Console.WriteLine("GrChild-Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
