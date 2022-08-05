using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

            //Even numbers until 40
            int val;
            for (val = 1; val <= 40; val++)
            {

                if (val % 2 == 0)
                {
                    Console.WriteLine(val);
                }
            }



            //Sum of odd nums in the array
            int total = 0;
            int[] A = new int[10] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 1)
                {
                    total += A[i];

                }

            }
            Console.WriteLine(total);



            //Perimeter and area of the circle
            int radius = 30;
            double area;
            double perimeter;
            area = radius * radius * (3.14);
            perimeter = 2 * radius * (3.14);
            Console.WriteLine($"Area is= {area}, Perimeter is= {perimeter}");


        }
    }
}
