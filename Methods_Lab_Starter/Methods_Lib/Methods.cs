using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            var days = totalDays / 7;
            var weeks = totalDays % 7;
            if (totalDays < 0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
            else
            {
                return (days, weeks);
            }
        }
        public static (int square, int cube, double root) PowersRoot(int num)
        {
            int square = num * num;
            int cube = num * num * num;
            double root = Math.Sqrt(Convert.ToDouble(num));
            return (square, cube, root);
        }
        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

    }
}
