using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_xUnit
{
    public class Calculator
    {
        double sum;
        string num1;
        string num2;

        double userNumber1;
        double userNumber2;

        Utils utils = new Utils();


        // Methods
        public void Addition()
        {

            try
            {
                Console.WriteLine("Please enter 2 numbers to get them sum up.\nFor decimal numbers use period as a separator.");
                Console.WriteLine("First number: ");
                num1 = Console.ReadLine();

                userNumber1 = utils.ConvertToDouble(num1);

                Console.WriteLine("\nPlus \n");
                Console.WriteLine("Second number: ");
                num2 = Console.ReadLine();
                
                userNumber2 = utils.ConvertToDouble(num2);

                // display result
                sum = utils.AddUp(userNumber1,userNumber2);
               

                utils.Result(sum);


            }
            catch (Exception ex)
            {
                utils.CatchWarrning();
            };

        }


        public void Subtraction()
        {

            try
            {

                Console.WriteLine("Please enter 2 numbers to get them subtract.\nFor decimal numbers use period as a separator.");
                Console.WriteLine("First number: ");
                num1 = Console.ReadLine();

                userNumber1 = utils.ConvertToDouble(num1);

                Console.WriteLine("\nMinus \n");
                Console.WriteLine("Second number: ");
                num2 = Console.ReadLine();

                userNumber2 = utils.ConvertToDouble(num2);
                // display result
                sum = utils.Subtract(userNumber1,userNumber2);
                // Round up to 2 decimals if needed
                //sum = Math.Round(sum, 2);

                utils.Result(sum);


            }
            catch (Exception ex)
            {
                utils.CatchWarrning();
            };

        }

        // Divide 2 numbers
        public void Division()
        {
            try
            {

                Console.WriteLine("Please enter 2 numbers to get them divided.\nFor decimal numbers use period as a separator.");
                Console.WriteLine("First number: ");
                num1 = Console.ReadLine();

                userNumber1 = utils.ConvertToDouble(num1);


                Console.WriteLine("\nDivided by: \n");
                Console.WriteLine("Second number: ");
                num2 = Console.ReadLine();

                userNumber2 = utils.ConvertToDouble(num2);
                
               
                // display result
                sum = utils.Divide(userNumber1,userNumber2);

                // Round up to 2 decimals if needed
                //sum = Math.Round(sum, 2);

                utils.Result(sum);
                


            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                utils.CatchWarrning();
            };

        }

        // Multiplicate 2 numbers
        public void Multiplication()
        {
            try
            {
                Console.WriteLine("Please enter 2 numbers to multiplicate them.\nFor decimal numbers use period as a separator.");
                Console.WriteLine("First number: ");
                num1 = Console.ReadLine();

                userNumber1 = utils.ConvertToDouble(num1);


                Console.WriteLine("\nMultiplicate by: \n");
                Console.WriteLine("Second number: ");
                num2 = Console.ReadLine();

                userNumber2 = utils.ConvertToDouble(num2);
                // display result
                sum = utils.Multiply(userNumber1,userNumber2);
                // Round up to 2 decimals if needed
                //sum = Math.Round(sum, 2);

                utils.Result(sum);


            }
            catch (Exception ex)
            {
                utils.CatchWarrning();
            };

        }
    }

}
