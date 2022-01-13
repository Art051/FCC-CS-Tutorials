namespace FCC_CS_Full_Course
{
    class Methods
    {

        public static void Main(string[] args)
        {
            SayHi();

            SayHi1("Mike");

            SayHiNameAge("Mike", 25);

        }

        public static void SayHi()
        {
            Console.WriteLine("Hello");
        }

        public static void SayHi1(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static void SayHiNameAge(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

    }
}
