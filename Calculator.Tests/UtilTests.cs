using Xunit;
using Calculator_xUnit;
using System;

namespace Calculator.Tests
{
    public class UtilTests
    {


        Utils utils = new Utils();


        [Fact]
        public void AddUpTest()
        {

            //initialize variables
            double number1 = 34.5;
            double number2 = 37.5;
            //Invoke method to test
            double res = utils.AddUp(number1, number2);
            //Verify
            Assert.IsType<double>(res);

        }
        [Fact]
        public void SubtractTest()
        {
            //initialize variables
            double number1 = 38.5;
            double number2 = 15.5;
            //Invoke method to test
            double res = utils.Subtract(number1, number2);
            //Verify 
            Assert.IsType<double>(res);

        }
        [Fact]
        public void DivideTest()
        {
            //initialize variables
            double number1 = 38.5;
            double number2 = 0;
            //Invoke method to test
            Action res = () => utils.Divide(number1, number2);
            //Verify

            DivideByZeroException exception = Assert.Throws<DivideByZeroException>(res);
            Assert.Equal("Division by zero not allowed\n\n", exception.Message);
        }
        [Fact]
        public void MultiplyTest()
        {
            //initialize variables
            double number1 = 38.5;
            double number2 = 5.5;
            //Invoke method to test
            double res = utils.Multiply(number1, number2);
            //Verify 
            Assert.IsType<double>(res);

        }

    }
}