using Using_Generics.test;

using NUnit.Framework;

namespace Using_Generics.test
{
    public class Tests
    {
        MaximumNumber Maxnum = new MaximumNumber();
        [Test]
        public void GivenInteger_FirstNumberMax_ReturnsNumber()
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
        public void GivenInteger_SecondNumberMax_ReturnsNumber()
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
        public void GivenInteger_ThirdNumberMax_ReturnsNumber()
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
        [Test]
        public void Givendouble_FirstNumberMax_ReturnsNumber()
        {
            //Arrange
            double firstNumber = 112.2;
            double secondNumber = 12.1;
            double thirdNumber = 10.1;
            double expected = 112.2;

            //Act
            double result = MaximumNumber.MaxNumber(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Givendouble_SecondNumberMax_ReturnsNumber()
        {
            //Arrange
            double firstNumber = 112.2;
            double secondNumber = 212.1;
            double thirdNumber = 10.1;
            double expected = 212.1;

            //Act
            double result = MaximumNumber.MaxNumber(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Givendouble_thirdNumberMax_ReturnsNumber()
        {
            //Arrange
            double firstNumber = 112.0;
            double secondNumber = 12.1;
            double thirdNumber = 510.1;
            double expected = 510.1;

            //Act
            double result = MaximumNumber.MaxNumber(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}