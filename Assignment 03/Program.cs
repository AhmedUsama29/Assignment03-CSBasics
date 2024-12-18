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

            #region Question 03: Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.WriteLine("Enter the start Number:");
            //string Start = Console.ReadLine();
            //bool flag1 = int.TryParse(Start, out int start);

            //Console.WriteLine("Enter the end Number:");
            //string End = Console.ReadLine();
            //bool flag2 = int.TryParse(End, out int end);

            //if (flag1 && flag2)
            //{
            //    Console.WriteLine("Prime numbers in the range are:");
            //    for (int i = start; i <= end; i++)
            //    {
            //        int count = 0;

            //        for (int j = 1; j <= i; j++) 
            //        {
            //            if (i % j == 0)
            //            {
            //                count++;
            //            }
            //        }

            //        if (count == 2) 
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter valid integers.");
            //}


            #endregion

            #region Question 04: Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.WriteLine("Enter the decimal number:");
            //string Decimal = Console.ReadLine();
            //bool flag = int.TryParse(Decimal, out int decimalNumber);

            //if (flag)
            //{
            //    string binary = "";
            //    while (decimalNumber > 0)
            //    {
            //        binary += (decimalNumber % 2);
            //        decimalNumber = decimalNumber / 2;
            //    }
            //    //reverse the binary number bec it's flipped
            //    char[] binaryArray = binary.ToCharArray();
            //    Array.Reverse(binaryArray);
            //    string reversedBinary = new string(binaryArray);
            //    Console.WriteLine($"Binary number is: {reversedBinary}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Question 05: Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            ////no need to do try parse [i get it]

            //Console.WriteLine("Enter the coordinates for point 1 (x1, y1):");
            //Console.Write("x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates for point 2 (x2, y2):");
            //Console.Write("x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates for point 3 (x3, y3):");
            //Console.Write("x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("y3: ");
            //double y3 = double.Parse(Console.ReadLine());

            //// (y2 - y1) / (x2 - x1) == (y3 - y1) / (x3 - x1)
            //bool oneline = (x2 - x1) * (y3 - y1) == (y2 - y1) * (x3 - x1);

            //if (oneline)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}


            #endregion

            #region Question 06: Within a company, the efficiency of workers is evaluated based on the duration required ,To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //Console.Write("Enter the time taken to complete the task: ");
            //string time = Console.ReadLine();
            //bool flag = double.TryParse(time, out double hours);

            //if (flag)
            //{
                
            //    if (hours >= 2 && hours <= 3)
            //    {
            //        Console.WriteLine("Highly efficient.");
            //    }
            //    else if (hours > 3 && hours <= 4)
            //    {
            //        Console.WriteLine("Increase your speed.");
            //    }
            //    else if (hours > 4 && hours <= 5)
            //    {
            //        Console.WriteLine("You need training to improve your speed.");
            //    }
            //    else if (hours > 5)
            //    {
            //        Console.WriteLine("You are required to leave the company.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Time cannot be less than 2 hours.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number for time.");
            //}

            #endregion
        }
    }
}