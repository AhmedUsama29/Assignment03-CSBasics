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

            //Console.WriteLine("Enter the int:");
            //String Text = Console.ReadLine();
            //bool flag = int.TryParse(Text, out int number);

            //if (flag)
            //{
            //    char[] TextArr = Text.ToCharArray();
            //    for (int i = TextArr.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(TextArr[i]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a valid number");
            //}
            #endregion

            #region Question 03:Write a program in C# Sharp to find prime numbers within a range of numbers.

            Console.WriteLine("Enter the start Number:");
            string Start = Console.ReadLine();
            bool flag1 = int.TryParse(Start, out int start);

            Console.WriteLine("Enter the end Number:");
            string End = Console.ReadLine();
            bool flag2 = int.TryParse(End, out int end);

            if (flag1 && flag2)
            {
                Console.WriteLine("Prime numbers in the range are:");
                for (int i = start; i <= end; i++)
                {
                    int count = 0;

                    for (int j = 1; j <= i; j++) 
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }

                    if (count == 2) 
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }


            #endregion
        }
    }
}