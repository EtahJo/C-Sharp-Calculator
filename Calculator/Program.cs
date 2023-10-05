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

            Console.WriteLine("This is a calculator");
            Console.Write("Enter Number : ");
            firstNumberText = Console.ReadLine();
         
            Console.Write("Operation:");
            operation = Console.ReadLine();
            Console.Write("Enter Second Number :");
            secondNumberText = Console.ReadLine();
            if (int.TryParse(firstNumberText,out firstNumber) && int.TryParse(secondNumberText,out secondNumber))
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

