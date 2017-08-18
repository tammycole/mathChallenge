﻿using System;

namespace MathChallenge
{

    class Program
    {
        static void Main(string[] args)
        {

            //request first number from user
            Console.WriteLine("Enter a whole number:");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            string value = Console.ReadLine();
            int number1;
            string notInt = "This is not an integer.";

            bool successfullyParsed = int.TryParse(value, out number1);
            if (successfullyParsed)
            {
                int successful = number1;
            }
            else
                Console.WriteLine(notInt);
             

            //request second number from user
            Console.WriteLine("Enter another number with the same number of digits:");
            // var number2 = Convert.ToInt32(Console.ReadLine());
            string value2 = Console.ReadLine();
            int number2;

            bool successfullyParsed2 = int.TryParse(value2, out number2);
            if (successfullyParsed2)
            {
                int successful = number2;
            }
            else
                Console.WriteLine(notInt);

            //get lengths of each number
            int length1 = number1.ToString().Length;
            // Console.WriteLine(length1);

            int length2 = number2.ToString().Length;
            //Console.WriteLine(length2);

            string userInput;
            string Answer;


            //test for the same number of digits before moving on
            if (length1 == length2)
            {
                Answer = Compare(number1, number2, length1);
            }
            else
            {
                userInput = "invalid user input - Check number of digits next time.";
                Console.WriteLine(userInput);
                Console.ReadKey();
            }

            //Method for removing last digits and iterating for the correct number of digits
            string Compare(int i, int x, int l)
            {
                int lastDigitI;
                int lastDigitX;

                lastDigitI = (i % 10);
                //Console.WriteLine(lastDigitI);
                lastDigitX = (x % 10);
                //Console.WriteLine(lastDigitX);

                //get comparison sum for first pair of digits
                int sumStatic = lastDigitI + lastDigitX;
                // Console.WriteLine(sumStatic);

                //sum of remaining pairs in do while loop
                do
                {
                    lastDigitI = (i % 10);
                    //Console.WriteLine(lastDigitI);
                    lastDigitX = (x % 10);
                    //Console.WriteLine(lastDigitX);
                    i = i / 10;
                    //Console.WriteLine(i);
                    x = x / 10;
                    // Console.WriteLine(x);
                    l--;
                    //Console.WriteLine(l);
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
            Console.ReadKey();
        }
    }
}





