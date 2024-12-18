namespace Assignment_03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Question 01: Write a program to allow the user to enter a string and print the REVERSE of it.

            Console.WriteLine("Enter the string:");
            String Text = Console.ReadLine();
            char[] TextArr = Text.ToCharArray();
            for (int i = TextArr.Length - 1; i >= 0; i--)
            {
                Console.Write(TextArr[i]);
            }

            #endregion Question 01: Write a program to allow the user to enter a string and print the REVERSE of it.


        }
    }
}