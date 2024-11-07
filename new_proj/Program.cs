using System;

namespace qbit_loops_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Trim().Split();
            double N = double.Parse(arr[0]);
            double P = double.Parse(arr[1]);
            double M = double.Parse(arr[2]);

            int Y = 0;
            double currentN = N;
            double percentage = P / 100;

            while (currentN < M)
            {
                currentN += currentN * percentage;
                currentN = Math.Floor(currentN * 100) / 100;
                Y++;
            }

            Console.WriteLine($"{Y}");
            Console.ReadLine();
        }
    }
}
