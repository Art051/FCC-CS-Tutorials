namespace FCC_CS_Full_Course
{
    class SwitchStatements
    {
        char myGrade = 'A';

        public void
            AssessGrade()
        {

            switch (myGrade)
            {
                case 'A':
                    Console.WriteLine("You Pass");
                    break;
                case 'F':
                    Console.WriteLine("You fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
        }
    }
}
