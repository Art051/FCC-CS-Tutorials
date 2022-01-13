namespace FCC_CS_Full_Course
{
    public class UserInput
    {

        public void ReqUserDetails()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine($"Hello {username}");
            Console.WriteLine(username);



            Console.Write("Enter age: ");
            string age = Console.ReadLine();
            Console.WriteLine($"You are {age} years old.");
            Console.WriteLine(username);
        }
    }
}