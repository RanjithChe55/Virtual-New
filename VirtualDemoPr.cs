using System;


namespace NewKeyDemo
{
    class Baseclass
    {
        public virtual void display()
        {
            Console.WriteLine("Base class Executed..");
            Console.ReadLine();
        }
    }
    class Derivedclass : Baseclass
    {
        public override void display()
        {
            Console.WriteLine("First Derived Class Override function");
            Console.ReadLine();

        }
    }
    class Derivedclass2 : Baseclass
    {
        public new void display()
        {
            Console.WriteLine("Second Derived Class function using new keyword");
            Console.ReadLine();



        }
    }
    class Mainclass
    {
        public static void Main()
        {
            
            Console.WriteLine("Override Function");
            Baseclass one = new Derivedclass();
            one.display();
            Console.WriteLine("Using new keyword");
            Baseclass two = new Derivedclass2();
            two.display();
        }
    }
}