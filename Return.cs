﻿namespace FCC_CS_Full_Course
{
    class Return
    {
        public static void Main(string[] args)
        {
            int sum = AddNumbers(4, 60);
            Console.WriteLine(sum);
        }

        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
