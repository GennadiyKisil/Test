using System;
using System.Collections.Generic;
using Older;

namespace HID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Older.Prop1.a);
            Older.Prop1 p = new Older.Prop1();

            Prop1.Ego ego1 = new Prop1.Ego();
            ego1.l = "Hello ";
            Prop1.Ego ego2 = new Prop1.Ego();
            ego2.l = "world, first records.";            
            Console.WriteLine((ego1 + ego2).ToString());

            
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
        private Ego instance;

        private Ego Instance { get => instance; set => instance = value; }

        public class Ego
        {
            public static string operator +(Ego e1, Ego e2)
            {
                return e1.l + e2.l;
            }

            public string l = "hello";
        }

        public Prop1()
        {
            instance = new Ego();
        }

        public override string Opc1()
        {
            return "This method in base class overriden."+instance.l;
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
