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

        }
    }
}
