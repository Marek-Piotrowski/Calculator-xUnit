using System;

namespace Calculator_xUnit // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int user;
            bool goodIndex = true;
            Calculator calc = new Calculator();
            Utils utils = new Utils();


            utils.Intro();

            do
            {
                utils.Menu();

                try
                {
                    user = int.Parse(Console.ReadLine());

                    switch (user)
                    {
                        case 0:
                            Console.WriteLine("Goodbye.");
                            goodIndex = false;
                            break;
                        case 1:
                            calc.Addition();
                            break;
                        case 2:
                            calc.Subtraction();
                            break;
                        case 3:
                            calc.Division();
                            break;
                        case 4:
                            calc.Multiplication();
                            break;
                        default:
                            utils.Ending();

                            break;
                    }
                }
                catch (Exception ex)
                {
                    utils.Ending();

                };
            }
            while (goodIndex);
            Console.WriteLine("Program closed");
        }
    }
}
