namespace FCC_CS_Full_Course
{
    class IfStatements
    {
        bool isStudent = false;
        bool isSmart = false;


        public void AssessConditions()
        {
            if (isStudent && isSmart)
            {
                Console.WriteLine("You are a student");
            }
            else if (isStudent && !isSmart)
            {
                Console.WriteLine("You are not a smart student");
            }
            else
            {
                Console.WriteLine("You are not a student and not smart");
            }

            // >, <, >=, <=, !=, ==
            if (1 < 3)
            {
                Console.WriteLine("number comparison was true");
            }
        }
    }
}
