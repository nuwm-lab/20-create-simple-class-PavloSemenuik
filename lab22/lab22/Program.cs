using System;
namespace SumSeriesExample
{
    public class SeriesSum
    {
        public double CalculateSum(double[] a)
        {
            double sum = 0;
            for (int i = 1; i <= a.Length; i++)
                sum += a[i - 1] / (i * (i + 1));
            return sum;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 3 values for a (separated by space): ");
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length != 3)
                {
                    Console.WriteLine("Error: You must enter exactly 3 values.");
                    return;
                }

                double[] a = new double[3];
                for (int i = 0; i < 3; i++)
                    a[i] = Convert.ToDouble(input[i]);

                SeriesSum seriesSum = new SeriesSum();
                double result = seriesSum.CalculateSum(a);
                Console.WriteLine($"The sum of the series is: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
