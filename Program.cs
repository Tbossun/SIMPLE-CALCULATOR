namespace SIMPLE_CALCULATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSTRUCTION ON OPERANDS
            Console.WriteLine("Press\n \"+\" for Addition,\n \"-\" for Substraction,\n \"/\" for Division and\n \"*\" for multiplication");
            do
            {
                //Input firstNumber 
                Console.Write("Enter First  Number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                //Enter operand
                Console.Write("Enter Operator: ");
                string operand = Console.ReadLine();
                //Input second number
                Console.Write("Enter Second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                double result = 0;
                //Condition and Operations
                switch (operand)
                {
                    case "+":
                        {
                            result = firstNumber + secondNumber;
                            break;
                        }
                    case "-":
                        {
                            result = firstNumber - secondNumber;
                            break;
                        }
                    case "/":
                        {
                            result = firstNumber / secondNumber;
                            break;
                        }
                    case "*":
                        {
                            result = firstNumber * secondNumber;
                            break;
                        }
                    default:
                        Console.WriteLine("Error! Please enter a a valid operator");
                        break;
                }

                //RESULT FORMAT
                Console.WriteLine("Result: {0} {1} {2} = {3}", firstNumber, operand, secondNumber, result);
                Console.Write("Do you want to perform another operation?\n (Y = Yes, N = No)");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye");
        }
    }
}