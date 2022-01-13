namespace FCC_CS_Full_Course
{
    class Constructors
    {
    }


    public class Books
    {
        public string title;
        public string author;

        public Books(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
    }

    public class Apps
    {
        public static void Main(string[] args)
        {
            Books book1 = new Books("Harry Potter", "JK Rowling");
            Console.WriteLine(book1.title);

            Books book2 = new Books("Lord of the Rings", "JRR Tolkien");
            Console.WriteLine(book2.title);
        }
    }

}
