namespace FCC_CS_Full_Course
{
    class ClassesAndObjects
    {
    }

    public class Book
    {
        public string title;
        public string author;
        public int numPages;
    }

    public class App
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.numPages = 400;

            Console.WriteLine(book1.title);

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "JRR Tolkien";
            book2.numPages = 300;

            Console.WriteLine(book2.title);
        }
    }

}
