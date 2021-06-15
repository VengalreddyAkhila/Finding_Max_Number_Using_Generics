using System;
using System.Collections.Generic;
using System.Text;

namespace Using_Generics
{
    public class MaximumNumber
    {
        /// <summary>
        /// Find Maximum of 3 Integers In UC1
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <param name="thirdNum"></param>
        /// <returns></returns>
        public static int MaxNumber(int firstNum, int secondNum, int thirdNum)
        {

            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                return thirdNum;
            }
            return 0;
        }

     
        /// <summary>
        /// find the maximum of 3 numbers in UC2
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <param name="thirdNum"></param>
        /// <returns></returns>
        public static Double MaxNumber(double firstNum, double secondNum, double thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                return thirdNum;
            }
            return 0;
        }
        /// <summary>
        /// find the maximum of 3 string in UC3
        /// </summary>
        /// <param name="firstNumstring"></param>
        /// <param name="secondNumstring"></param>
        /// <param name="thirdNumstring"></param>
        /// <returns></returns>
        public static string MaxNumber(string firstNumstring, string secondNumstring, string thirdNumstring)
        {
            if (firstNumstring.CompareTo(secondNumstring) > 0 && firstNumstring.CompareTo(thirdNumstring) > 0)
            {
                return firstNumstring;
            }
            if (secondNumstring.CompareTo(firstNumstring) > 0 && secondNumstring.CompareTo(thirdNumstring) > 0)
            {
                return secondNumstring;
            }
            if (thirdNumstring.CompareTo(firstNumstring) > 0 && thirdNumstring.CompareTo(secondNumstring) > 0)
            {
                return thirdNumstring;
            }
            return default;
        }


        public static T MaxNumber<T>(T firstNum, T secondNum, T thirdNum)
        {

            if (Comparer<T>.Default.Compare(firstNum, secondNum) > 0 && Comparer<T>.Default.Compare(firstNum, thirdNum) > 0)
            {
                return firstNum;
            }
            if (Comparer<T>.Default.Compare(secondNum, thirdNum) > 0 && Comparer<T>.Default.Compare(secondNum, firstNum) > 0)
            {
                return secondNum;
            }
            if (Comparer<T>.Default.Compare(thirdNum, firstNum) > 0 && Comparer<T>.Default.Compare(thirdNum, secondNum) > 0)
            {
                return thirdNum;
            }
            return default;
        }
    }
}
