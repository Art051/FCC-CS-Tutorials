namespace FCC_CS_Full_Course
{
    class ForLoops
    {
        public void WhileLoop()
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
        }

        public void ForLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

        }

        public void ForEach()
        {
            int[] luckyNums = { 4, 8, 15, 16, 23, 42 };
            foreach (int luckyNum in luckyNums)
            {
                Console.WriteLine(luckyNum);
            }
        }

    }
}
