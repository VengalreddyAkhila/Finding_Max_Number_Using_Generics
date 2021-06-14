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
       
    }
}
