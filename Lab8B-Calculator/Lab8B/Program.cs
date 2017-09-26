using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program allows you to perform an operation on two numbers.");

            try
            {
                Console.WriteLine("Enter a number, operator, and another number seperated by spaces: ");

              
                char[] seperator = {' '};
                string[] myCalculation;

                string userInput = Console.ReadLine();

                myCalculation = userInput.Split(seperator);
                //Console.WriteLine(myCalculation[0] + myCalculation[1] + myCalculation[2]);

                double operand1 = Convert.ToDouble(myCalculation[0]);

               // Console.WriteLine("Enter a operator (+, -, *, /):  ");
                string theOperator = myCalculation[1];

                // Console.WriteLine("Enter another number: ");
                double operand2 = Convert.ToDouble(myCalculation[2]);

                double Result = 0.00; // double datatype allows for use of decimals


                if (theOperator == "+" || theOperator == "-" || theOperator == "*" || theOperator == "/")
                {
                    Console.WriteLine("Operation OK - if");
                }
                else
                {
                    throw new Exception("Invalid Operator"); //Creating a "new" exception, constructor
                    //Console.WriteLine("Bad Operation -If ");
                }

                switch (theOperator)
                {
                    case "+":
                        Result = operand1 + operand2;
                        Console.WriteLine(operand1 + theOperator + operand2 + " = " + Result);
                        break;

                    case "-":
                        Result = operand1 - operand2;
                        Console.WriteLine(operand1 + theOperator + operand2 + " = " + Result);
                        break;

                    case "*":
                        Result = operand1 * operand2;
                        Console.WriteLine(operand1 + theOperator + operand2 + " = " + Result);
                        break;

                    case "/":
                        Result = operand1 / operand2;
                        Console.WriteLine(operand1 + theOperator + operand2 + " = " + Result);
                        break;
                    default:
                        Console.WriteLine("Bad Operation -Switch ");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                //  Console.WriteLine("I only accept operators. Please enter (+, -, *, /)");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {

                Console.WriteLine("It worked!");
            }
            //Console.WriteLine("\n{ 0} {1} {2} ={3}", operand1, theOperator, operand2, Result);

        }
    }
}
