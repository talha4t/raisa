using System;

namespace _chapter_08
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.Write("Hello ");

            //PrintSomething();
            // PrintSomething();
            // PrintSomething();
            // PrintSomething();

            // Console.WriteLine();

            //ShowName();

            // double a = 10.5, b = 9.5;

            //string s = "talha";

            // string s1 = str(s);

            // Console.WriteLine(s1);

            // ShowName("Talha");
            // string name = "Mahmud";
            // ShowName(name);

            int a = 10, b = 15;

            SWAP(a, b);

            Console.WriteLine("a = " + a +" " + "b = " + b);

        }

        static void SWAP(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        } 

        // static void ShowName(string aName)
        // {
         //   Console.WriteLine(aName);
        //}

        // static string str(string s)
        //{
            // Console.WriteLine(s + "Mahmud");
          //  return s;
//        }

        //static void PrintSomething()
        //{
          //  Console.Write("World!");
        //}
    }
}