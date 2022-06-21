using System;

namespace ConsoleApp11
{
    class result
    {
        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            result.solve(meal_cost, tip_percent, tax_percent);
        }
    }
}