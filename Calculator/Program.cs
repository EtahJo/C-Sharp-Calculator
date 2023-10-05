using System;


namespace Calculator
{
    class Program
    {
        public static void Main()
        {
            int firstNumber;
            int secondNumber;
            string operation;
            float result;
            string firstNumberText;
            string secondNumberText;
            bool didParseFirst=false;
            bool didParseSecond = false;

            Console.WriteLine("This is a calculator");
            while (didParseFirst == false || didParseSecond == false)
            {
               
                Console.Write("Enter Number : ");
                firstNumberText = Console.ReadLine();

                Console.Write("Operation:");
                operation = Console.ReadLine();
                Console.Write("Enter Second Number :");
                secondNumberText = Console.ReadLine();
                didParseFirst = int.TryParse(firstNumberText, out firstNumber) ;
                didParseSecond = int.TryParse(secondNumberText, out secondNumber);
                if (didParseFirst && didParseSecond)
                {
                    if (operation == "+")
                    {
                        result = firstNumber + secondNumber;
                    }
                    else if (operation == "-")
                    {
                        result = firstNumber - secondNumber;

                    }
                    else if (operation == "*")
                    {
                        result = firstNumber * secondNumber;
                    }
                    else if (operation == "%")
                    {
                        result = firstNumber % secondNumber;
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                    }

                    Console.WriteLine("Answer for {0} {1} {2} is : {3}", firstNumber, operation, secondNumber, result);
                }
                else
                {
                    Console.WriteLine("Your didn't enter a number");
                }
            }
          




        }
    }
}

