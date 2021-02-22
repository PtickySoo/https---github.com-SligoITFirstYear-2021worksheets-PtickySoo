using System;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varibles
            double totalScores = 0;
            double average;
            int counter = 0;

            double input =0;
            do
            {
                Console.WriteLine("Enter test score!");
                if(input != -999)
                {
                    totalScores += input;
                    counter++
                }
            }
            while (input != -999);

            average = totalScores / counter;

            Console.WriteLine("The average for {0} score is {1}", counter, average);
        }
    }
}
