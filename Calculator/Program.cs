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

            Console.WriteLine("This is a calculator");
            Console.Write("Enter Number : ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Operation:");
            operation = Console.ReadLine();
            Console.Write("Enter Second Number :");
            secondNumber = int.Parse(Console.ReadLine());

            if(operation== "+")
            {
                result = firstNumber + secondNumber;
            }else if (operation == "-")
            {
                result = firstNumber - secondNumber;

            }else if(operation == "*")
            {
                result = firstNumber * secondNumber;
            }else if (operation == "%")
            {
                result = firstNumber % secondNumber;
            }
            else
            {
                result = firstNumber / secondNumber;
            }

            Console.WriteLine("Answer for {0} {1} {2} is : {3}",firstNumber,operation,secondNumber,result);



        }
    }
}

