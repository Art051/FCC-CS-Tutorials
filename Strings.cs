namespace FCC_CS_Full_Course
{
    class Strings
    {
        string greeting = "Hello";
        //      indexes:   01234

        public void PrintingStrings()
        {
            Console.WriteLine(greeting[0]);
            Console.WriteLine(greeting.Length);


            Console.WriteLine(greeting.Length);
            Console.WriteLine(greeting[0]);
            Console.WriteLine(greeting.IndexOf("llo"));
            Console.WriteLine(greeting.IndexOf("z"));
            Console.WriteLine(greeting.Substring(2));
            Console.WriteLine(greeting.Substring(1, 3));


        }


    }
}
