namespace FCC_CS_Full_Course
{
    class Math
    {

        int num = 10;

        public void MathOperators()
        {
            Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
            Console.WriteLine(10 % 3);        // Modulus Op. : returns remainder of 10/3
            Console.WriteLine(1 + 2 * 3);     // order of operations
            Console.WriteLine(10 / 3.0);      // int's and doubles


            num += 100; // +=, -=, /=, *=
            Console.WriteLine(num);

            num++;
            Console.WriteLine(num);

            //  Console.WriteLine(Math.Pow(2, 3));
            // Console.WriteLine(Math.Sqrt(144));
            // Console.WriteLine(Math.Round(2.7));
        }


    }
}
