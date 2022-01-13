namespace FCC_CS_Full_Course
{
    class BuildACalculator
    {
        public void SumValues()
        {
            Console.Write("Enter num1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter num2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }

    }
}