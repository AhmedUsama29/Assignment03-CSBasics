namespace Assignment_03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Question 01: Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("Enter the string:");
            //String Text = Console.ReadLine();
            //char[] TextArr = Text.ToCharArray();
            //for (int i = TextArr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(TextArr[i]);
            //}

            #endregion Question 01: Write a program to allow the user to enter a string and print the REVERSE of it.

            #region Question 02: Write a program to allow the user to enter int and print the REVERSED of it.

            Console.WriteLine("Enter the int:");
            String Text = Console.ReadLine();
            bool flag = int.TryParse(Text, out int number);

            if (flag)
            {
                char[] TextArr = Text.ToCharArray();
                for (int i = TextArr.Length - 1; i >= 0; i--)
                {
                    Console.Write(TextArr[i]);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
            #endregion
        }
    }
}