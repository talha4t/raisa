using System;
namespace _chapter07
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1D array
            // int[] a = new int[5] {1, 2, 3, 4, 5};


            // for (int i = a.GetLength(0) - 1; i >= 0; i--)
            //     Console.Write(a[i] + " ");

            // 2D array
            // int[ , , ] arr = new int[3, 3] {{1, 2, 3},
            //                               {4, 5, 6},
            //                                {7, 8, 9}};


            // for (int i = 0; i < arr.GetLength(0); i++) {
            //     for (int j = 0; j < arr.GetLength(1); j++) {
            //         Console.Write(arr[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }

            // jagged array
            // int[][] jagged = new int[3][];

            // jagged[0] = new int[4] {1, 2, 3, 4};
            // jagged[1] = new int[3] {1, 2, 3};
            // jagged[2] = new int[5] {1, 2, 3, 4, 5};


            // Console.WriteLine(jagged[1][2]);
            

            // string s = "12345";
            
            // // normal order 
            // for (int i = 0; i < s.Length; i++) {
            //     Console.Write(s[i]);
            // }

            // Console.WriteLine();

            // // reverse order 
            // for (int i = s.Length - 1; i >= 0; i--) {
            //     Console.Write(s[i]);
            // }

            // string[] str = new string[5] {"rifat", "rafi",
            //                     "raisa", "asha", "pavel"};

            // for (int i = 0; i < str.GetLength(0); i++) 
            //     Console.WriteLine(str[i]);

            // string s = "1 2 3 4 5";
        }
    }
}