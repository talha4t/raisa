using System;
namespace _chapter04
{
    class Program
    {
        public static void Main(string[] args)
        {
           
        //    int sum = a / b + c + d; // binary op

        //    int i = i + 1; // unary op
        //    i++; // unary
        //    i--;

        // int a = 1; // a = 1
        // a++;  // a = 2
        // // a = 2
        // Console.WriteLine(++a); // a = 2
        // // a = 3
        // Console.Write(a);

        // int a = 2;
        // a--;

        // Console.WriteLine(--a); // a = 0

        // Console.Write(a); // a  = 0


        // logical op  

        
        // bool a = false; // 1
        // bool b = true; // 0

        // if (a && b) { // and
        //     Console.Write("Both true");
        // }
        // else 
        //     Console.Write("One of them is false");

        // if (a || b) // or 
        //     Console.Write("true");

        // if (!b) // not
        //     Console.Write("A");


        //  int n = 11;

        //  bool isEven;

        // isEven = (n % 2 == 0) ? true : false; // logical operator

        //Console.WriteLine(isEven);
        //Console.ReadKey();


        // int a = 100;

        // a *= 10;

        // // bitwise and
        // 5 & 5 == 5
        
        // 0101
        // 0101
        // ----
        // 0101

        // 3 & 7 == 3
        
        // 0011
        // 0111
        // ----
        // 0011
        
        // // bitwise or 
        // 2 | 4 == 6
        
        // 0010
        // 0100
        // ----
        // 0110  6

        // find even odd number using bitwise operation.
        
        // int n = 10;
        
        // 6 & 1 == 1;
        
        // 0100 
        // 0001
        // ----
        // 10001000100
        // 00000000001
        // ----
        // 0000000000

        // if (0) {
        //     "o"

        // }
        // else
        // {
            
        // }

        int a = 3; // 0011
        int b = 7; // 0111
        int c = 0; // 0100

        // c = a & b; // and
        // Console.WriteLine(c);

        // c = a | b; // or 
        // Console.WriteLine(c);

        // c = a ^ b; // xor
        // Console.WriteLine(c);

        c = ~a;
        Console.WriteLine(c);

        // left shift
        // c = a << 2; // move all bits right to left one by one 
        // Console.WriteLine(c);

        // // right shift
        // c = a >> 2; // move all bits left to right one by one
        // Console.WriteLine(c);


        }
    }
}