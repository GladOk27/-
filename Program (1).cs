using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MyClass
    {
        public byte a;
        public byte b;
        public byte c;

        public MyClass() { }
        public MyClass(byte x, byte y, byte z)
        {
            a = x;
            b = y;
            c = z;
        }

        public void rewrite()
        {
            Console.WriteLine("Открыто = " + a);
            Console.WriteLine("Откпыто = " + b);
            Console.WriteLine("Открыто = " + c);

        }
    }

    class Program
    {
        static void Main()
        {
            MyClass obj = new MyClass();
            obj.a = 10;

            MyClass obj1 = new MyClass(10, 5, 2);
            obj1.rewrite();

            Console.ReadLine();
        }
    }
}
