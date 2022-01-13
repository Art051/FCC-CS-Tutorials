namespace FCC_CS_Full_Course
{
    class ExcHandling
    {

        public void TryCatch()
        {

            // this code takes a number from the user and
            // divides 10 by it. Enter '0' to trigger the exception
            try
            {
                int division = 10 / Convert.ToInt32(Console.ReadLine());
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Not best practice to use general Exception
            }

            // throws new exception
            throw new DivideByZeroException("can't divide numbers");
        }

    }
}
