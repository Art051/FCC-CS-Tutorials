namespace FCC_CS_Full_Course
{
    class DataTypes
    {
        string name = "Mike";    // String's are objects not primitives
        char testGrade = 'A';    // single 16-bit Unicode character.

        // short, int, long can be pre-pended with 'u' for 'unsigned'
        byte age0 = 0;           // 8-bit unsigned integer
        short age1 = 10;         // 16-bit signed integer.
        int age2 = 20;           // 32-bit signed integer
        long age3 = 30L;         // 64-bit signed integer

        float gpa0 = 2.5F;       // 32-bit floating point
        double gpa1 = 3.5;       // 64-bit double-precision floating point
        decimal gpa2 = 4.5M;     // 128-bit precise decimal

        bool isTall;             // 1 bit -> true/false

        public void PrintDetails()
        {
            Console.WriteLine("Your name is " + name);
            Console.WriteLine($"Your name is {name}");
        }
    }
}