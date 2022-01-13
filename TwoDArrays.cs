namespace FCC_CS_Full_Course
{
    class TwoDArrays
    {


        // int [][] numberGrid = new int[2][3];
        int[][] numberGrid = { new int[] { 1, 2 }, new int[] { 3, 4 } };


        public void IterateArray()
        {
            numberGrid[0][1] = 99;
            Console.WriteLine(numberGrid[0][0]);
            Console.WriteLine(numberGrid[0][1]);

            for (int i = 0; i < numberGrid.Length; i++)
            {
                for (int j = 0; j < numberGrid[i].Length; j++)
                {
                    Console.WriteLine(numberGrid[i][j]);
                }
            }
        }
    }
}