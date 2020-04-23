using System;
using UnitTestingExercise;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -1, -1, -3)]
        public void AddTester(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var add = new UnitTestMethods();
            //Act
            var actual = add.Add(num1, num2, num3);
            //Assert
            actual.Equals(expected);

        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 1, -1)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var sub = new UnitTestMethods();
            //Act
            var actual = sub.Subtract(minuend, subtrhend);
            //Assert
            actual.Equals(expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(0, 1, 0)]
        [InlineData(-1, 1, -1)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var mult = new UnitTestMethods();
            //Act
            var actual = mult.Multiply(num1, num2);
            //Assert
            actual.Equals(expected);

        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(0, 1, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var div = new UnitTestMethods();
            //Act
            var actual = div.Divide(num1, num2);
            //Assert
            actual.Equals(expected);
        }

        [Fact]
        public void  IsNumberDivisibleByN()
        {
            //Arrange
            var divN = new UnitTestMethods();
            //Act
            var actual = divN.IsDivisibleByN(6, 2);
            //Assert
            actual.Equals(true);
        }

        [Fact]
        public void IsEven()
        {
            //Arrange
            var even = new UnitTestMethods();
            //Act
            var actual = even.IsEven(2);
            //Assert
            actual.Equals(true);
        }
    }
}
