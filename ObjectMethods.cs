namespace FCC_CS_Full_Course
{
    class ObjectMethods
    {

        Student student1 = new Student("Jim", "Business", 2.8);
        Student student2 = new Student("Pam", "Art", 3.6);

        public void CheckHonors()
        {
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

        }
    }
}
