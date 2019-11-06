using System;
using System.Collections.Generic;
using HidSharp;

namespace HID
{
    class Program
    {
        static void Main(string[] args)
        {
            Older.Prop1 p = new Older.Prop1();

            Console.WriteLine(p.Opc1());
            Console.WriteLine(p.ToString());
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    
}

namespace Older
{
    class Prop1 : Prop
    {
        public override string Opc1()
        {
            return "This method in base class overriden.";
        }
    }
    abstract class Prop
    {
        public static string a = "1";

        public string Desc
        {
            get
            {
                return a;
            }
        }

        public string Opc()
        {
            return a;
        }
        public abstract string Opc1();
    }
}
