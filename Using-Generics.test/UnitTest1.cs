using Using_Generics.test;

using NUnit.Framework;

namespace Using_Generics.test
{
    public class Tests
    {
        MaximumNumber Maxnum = new MaximumNumber();
        /// <summary>
        /// testcases for maximum of 3 integernumbers
        /// </summary>
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
        /// <summary>
        /// testcases for maximum of 3 double numbers
        /// </summary>
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
        /// <summary>
        /// testcases for maximum of 3 stringvalues
        /// </summary>
        [Test]
        public void Givenstring_firstNumberMax_ReturnsNumber()
        {
            //Arrange
            string firstNumber = "abcde";
            string secondNumber = "abc";
            string thirdNumber = "ab";
            string expected = "abcde";

            //Act
            string result = MaximumNumber.MaxNumber(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Givenstring_secondNumberMax_ReturnsNumber()
        {
            //Arrange
            string  firstNumber = "ab";
            string  secondNumber = "abcd";
            string thirdNumber = "a";
            string expected = "abcd";

            //Act
            string result = MaximumNumber.MaxNumber(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Givenstring_thirdNumberMax_ReturnsNumber()
        {
            //Arrange
            string firstNumber = "a";
            string secondNumber = "abc";
            string thirdNumber = "abcd";
            string expected = "abcd";

            //Act
            string result = MaximumNumber.MaxNumber(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}