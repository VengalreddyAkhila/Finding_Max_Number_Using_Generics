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
            Console.WriteLine("Maximum Number");
            int output = MaximumNumber.MaxNumber(11, 22, 33);
            Console.WriteLine(output);
           
        }
    }
}
