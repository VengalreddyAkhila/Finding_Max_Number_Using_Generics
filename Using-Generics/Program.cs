using System;

namespace Using_Generics
{
    class Program
    {
        /// <summary>
        /// finding maximum numbers using test cases
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to GenricsMethod");
           
            //getting output for intergernumbers,doublenumbers,stringnumbers
            Console.WriteLine("Maximum Number");
            MaximumNumber maxnumber = new MaximumNumber();
            int output = MaximumNumber.MaxNumber<int>(11, 22, 33);
            Console.WriteLine(output);           
            double doubleoutput = MaximumNumber.MaxNumber<double>(11.5, 22.6, 12.7);
            Console.WriteLine(doubleoutput);
            string stringoutput = MaximumNumber.MaxNumber<string>("ab","abcd","abcdefg");
            Console.WriteLine(stringoutput);           



        }
    }
}
