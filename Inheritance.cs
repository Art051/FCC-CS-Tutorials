namespace FCC_CS_Full_Course
{
    internal class Inheritance
    {

        public class Chef
        {

            public void MakeChicken()
            {
                Console.WriteLine("The chef makes chicken");
            }

            public void MakeSalad()
            {
                Console.WriteLine("The chef makes salad");
            }

            public virtual void MakeSpecialDish()
            {
                Console.WriteLine("The chef makes a special dish");
            }
        }

        public class ItalianChef : Chef
        {
            public void MakePasta()
            {
                Console.WriteLine("The Chef make's past");
            }

            public override void MakeSpecialDish()
            {
                Console.WriteLine("The chef makes chicken parm");
            }
        }

        public class App
        {
            public static void Main(string[] args)
            {

                Chef myChef = new Chef();
                myChef.MakeChicken();

                ItalianChef myItalianChef = new ItalianChef();
                myItalianChef.MakeChicken();
            }
        }



    }
}
