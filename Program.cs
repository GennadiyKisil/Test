using System;
using System.Collections.Generic;

namespace HID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Older.Prop1.a);
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
        private Ego instance;

        private Ego Instance { get => instance; set => instance = value; }

        class Ego
        {
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
