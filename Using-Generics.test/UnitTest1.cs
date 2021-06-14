using Using_Generics.test;

using NUnit.Framework;

namespace Using_Generics.test
{
    public class Tests
    {
        MaximumNumber Maxnum = new MaximumNumber();
        [Test]
        public void Given_FirstNumberMax_ReturnsNumber()
        {
            //Arrange
            int firstNumber = 40;
            int secondNumber = 0;
            int thirdNumber = 10;
            int expected = 40;

            //Act
            int result = MaximumNumber.MaxNumber(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Given_SecondNumberMax_ReturnsNumber()
        {
            //Arrange
            int firstNumber = -6;
            int secondNumber = 10;
            int thirdNumber = 2;
            int expected = 10;

            //Act
            int result = MaximumNumber.MaxNumber(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]        
        public void Given_ThirdNumberMax_ReturnsNumber()
        {
            //Arrange
            int firstNumber = 11;
            int secondNumber = 22;
            int thirdNumber = 33;
            int expected = 33;

            //Act
            int result = MaximumNumber.MaxNumber(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}