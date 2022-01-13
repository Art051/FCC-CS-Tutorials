namespace FCC_CS_Full_Course
{
    class ExponentMethod
    {

        public int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}