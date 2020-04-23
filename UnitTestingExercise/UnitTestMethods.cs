using System;
using UnitTestingExercise;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Create an Add method that passes 3 integers
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // Create a Subtract method that passes 2 integers
            // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // Create a Divide method that passes 2 integers

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote
        public bool IsDivisibleByN(int num, int n)
        {
            if (num % n == 0)
                return true;
            else
                return false;
        }

        public bool IsEven(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }
        
    }
}
