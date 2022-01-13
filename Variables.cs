namespace FCC_CS_Full_Course
{
    public class Variables
    {

        public void PrintStory()
        {
            string characterName = "George";
            int characterAge = 70;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterAge = 80;

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

        }
    }
}
