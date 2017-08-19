using System;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //request first number from user
            Console.WriteLine("Enter a whole number:");
            string value1 = Console.ReadLine();
            int number1 = validInteger(value1);

            //request second number from user
            Console.WriteLine("Enter another whole number with the same number of digits:");
            string value2 = Console.ReadLine();
            int number2 = validInteger(value2);

            //get lengths of each number
            int length1 = number1.ToString().Length;
            int length2 = number2.ToString().Length;

            string userInput;

            //test for the same number of digits before moving on
            if (length1 == length2)
            {
                string Answer = Convert.ToString(Compare(number1, number2, length1));
            }
            else
            {
                userInput = "invalid user input - Check number of digits next time.";
                Console.WriteLine(userInput);
                Console.ReadKey();
            }
            Console.ReadKey();
        }

        //method to validate user input
        static int validInteger(string d1)
        {
            int value = 0;
            string notInt = "This is not an integer.";
            //validate that input is an integer
            {
                bool successfullyParsed = int.TryParse(d1, out value);
                if (successfullyParsed)
                {
                    int number1 = Convert.ToInt32(value);
                    return value;
                }
                else
                {
                    Console.WriteLine(notInt);
                    Console.ReadKey();
                    Environment.Exit(0);
                    return value;
                }
            }
        }
        //Method for removing last digits and iterating for the correct number of digits
        static string Compare(int i, int x, int l)
        {
            int lastDigitI;
            int lastDigitX;

            lastDigitI = (i % 10);
            lastDigitX = (x % 10);

            //get comparison sum for first pair of digits
            int sumStatic = lastDigitI + lastDigitX;

            //sum of remaining pairs in do while loop
            do
            {
                lastDigitI = (i % 10);
                lastDigitX = (x % 10);
                i = i / 10;
                x = x / 10;
                l--;
                int sumCompare = lastDigitI + lastDigitX;

                if (sumCompare != sumStatic)
                {
                    Console.WriteLine("False");
                    return "False";
                }
            }
            while (l != 0);
            Console.WriteLine("True");
            return "True";
        }

    }
}





