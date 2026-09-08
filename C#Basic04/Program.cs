using System.Text;

namespace C_Basic04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st Answer
            string title = "Clean Code";
            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

            #region 2nd Answer
            string title2 = "Clean Code";
            string title02 = "Clean Code";
            Console.WriteLine(ReferenceEquals(title02, title2));
            // Output: True 
            // Explanation: In C#, string literals are interned, meaning that identical string literals are stored only once in memory. 
            //Therefore, both title2 and title02 refer to the same memory location, resulting in ReferenceEquals returning true.
            #endregion

            #region 3rd Answer
            StringBuilder bookList = new StringBuilder();
            bookList.Append("Book List");
            bookList.Append(" - Updated");
            Console.WriteLine(bookList);
            // StringBuilder is a mutable class that allows you to efficiently modify strings without creating new objects.
            #endregion

            #region 4th Answer
            bookList.Replace("Book List", "Library");
            Console.WriteLine(bookList);
            // The Replace method is used to replace a specified substring with another substring in the StringBuilder.
            #endregion

            #region 5th Answer
            //string title = "Clean Code";
            int pages = 464;
            Console.WriteLine("Book: " + title + ", Pages: " + pages);
            // Explanation: The + operator is used to concatenate strings and variables. In this case, it combines the title and pages into a single string.
            #endregion

            #region 6th Answer
            Console.WriteLine($"Book: {title}, Pages: {pages}");
            // The $ symbol before the string indicates that it is an interpolated string.
            #endregion

            #region 7th Answer
            Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));
            // The string.Format method is used to format strings by replacing placeholders with actual values.
            #endregion

            #region 8th Answer
            //int pages = 464;
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region 9th Answer
            //int pages = 464;
            bool isAvilable = true;
            if (isAvilable && pages > 300)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region 10th Answer
            string title10 = "Refactoring";
            switch (title10)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region 11th Answer
            //int pages = 464;
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            #region 12th Answer
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int i;
            for (i = 0; i < books.Length; i++)
            {
                Console.WriteLine(i+1 + ". " + books[i]);
            }
            #endregion

            #region 13th Answer
            i = 0;
            while (i < books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }
            #endregion

            #region 14th Answer
            int count = 0;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);
            #endregion

            #region 15th Answer
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion

            #region 16th Answer
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    Console.WriteLine(book);
                    break;
                }
                Console.WriteLine(book);

            }
            #endregion

        }
    }
}
