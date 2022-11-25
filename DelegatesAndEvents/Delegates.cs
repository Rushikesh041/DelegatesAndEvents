using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Delegates
    {
        public static void Addition(int a, int b)
        {
            Console.WriteLine("Addition is : " + (a + b));
        }
        public static void Substraction(int a, int b)
        {
            Console.WriteLine("Substraction is : " + (a - b));
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication is : " + (a * b));
        }
    }
    public class ArrayDelegates
    {
        delegate void Del(int x, int y);

        public static void ImplementDelegates()
        {
            Del obj = new Del(Delegates.Addition);
            obj += Delegates.Substraction;
            obj += Delegates.Multiplication;
            obj(10, 5);
            Console.WriteLine();
            obj(20, 10);
            Console.WriteLine();
            obj(40, 20);
        }
    }
}
