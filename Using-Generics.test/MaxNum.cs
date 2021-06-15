using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Using_Generics.test
{
    /// <summary>
    /// using generics method find the maximum number
    /// </summary>
    public class MaxNum
    {
       
        /// <summary>
        /// finding maximum number in integer type
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
            int result = MaximumNumber.MaxNumber<int>( firstNumber,  secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// finding maximum number in double type
        /// </summary>
        [Test]
        public void Givendouble_SecondNumberMax_ReturnsNumber()
        {
            //Arrange
            double firstNumber = 112.2;
            double secondNumber = 212.1;
            double thirdNumber = 10.1;
            double expected = 212.1;

            //Act
            double result = MaximumNumber.MaxNumber<double>(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// finding maximum number in stringtype
        /// </summary>
        [Test]
        public void Givenstring_thirdNumberMax_ReturnsNumber()
        {
            //Arrange
            string firstNumber = "a";
            string secondNumber = "abc";
            string thirdNumber = "abcd";
            string expected = "abcd";

            //Act
            string result = MaximumNumber.MaxNumber<string>(firstNumber, secondNumber, thirdNumber);

            //Assert
            Assert.AreEqual(expected, result);
        }


    }
}
