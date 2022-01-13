namespace FCC_CS_Full_Course
{
    class MadLibsGame
    {

        public void BuildMadLibs()
        {

            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            Console.Write("Enter plural noun: ");
            string pluralNoun = Console.ReadLine();

            Console.Write("Enter celebrity: ");
            string celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I love {celebrity}");

        }
    }
}
