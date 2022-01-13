namespace FCC_CS_Full_Course
{
    class GettersSetters
    {
        Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
        Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");


        public void DisplayMovie()
        {
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }



    }
}
