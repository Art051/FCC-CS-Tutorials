﻿namespace FCC_CS_Full_Course
{
    class Arrays
    {
        int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
        //         indexes:    0  1  2   3   4   5

        public void PrintElements()
        {
            luckyNumbers[0] = 90;
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(luckyNumbers.Length);
        }

    }
}
