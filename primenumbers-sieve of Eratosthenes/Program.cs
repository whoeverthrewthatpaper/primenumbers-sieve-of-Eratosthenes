using System;

namespace primenumbers_sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = " Please enter number > 1 to search for prime numbers in between ";
            Console.WriteLine(message);

            int number = Convert.ToInt32(Console.ReadLine()); // convert string to int 

            int[] arr = new int[number];

            numbersForCalculation(arr, number); // array of numbers 

            calc(arr, number);// calculation to see if number is prime 

            Results(arr, number);// will show all prime numbers from 1- number
            Console.ReadKey();

        }

        static void numbersForCalculation(int[] arr, int number)
        {
            for (int i = 0; i < number; i++)
            {
                arr[i] = i + 1;
            }
            arr[0] = 0;
        }
        static void calc(int[] arr, int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (arr[i] != 0)
                {
                    for (int j = 2; j < Math.Sqrt(number); j++)
                    {
                        if (arr[i] == j) arr[i] = j;
                        else if (arr[i] % j == 0) arr[i] = 0;
                    }
                }
            }
        }
        static void Results(int[]arr, int number) 
        {
            string message = String.Format("Prime numbers from 1 to {0} ", number) ;
            Console.WriteLine(message);
            for (int i= 0; i< number; i++)
            {
                if (arr[i] != 0)
                    Console.WriteLine(arr[i]);
            }
        }
    }
}
