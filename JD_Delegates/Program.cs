using System;

namespace JD_Delegates
{
    internal class Program
    {
        delegate string MyDel(); 

        static void Main(string[] args)
        {
            MyDel testDel = TestFunction;
            testDel += TestFunction2;
           
            string result = testDel();

            Console.WriteLine(result);
        }
        static string TestFunction()
        {
            return "Hello world";
        }
        static string TestFunction2()
        {
            return "Seech";
        }

    }
}
