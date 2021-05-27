using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtilities
{
    public static class ConsoleHelper
    {
        public static int ReadNumber(string label, int maxAttempts, int defaultValue)
        {
            label = label ?? "please enter a number";
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                Console.Write($"{label}=");
                string value = Console.ReadLine();
                if(int.TryParse(value, out int number))
                {
                    return number;
                }

                attempts++;
                Console.Write($"Value {value} is not a number, please enter one!, attempts remaining {maxAttempts-attempts}");
            }

            return defaultValue;
        }
    }
}
