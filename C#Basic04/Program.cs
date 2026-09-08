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

        }
    }
}
