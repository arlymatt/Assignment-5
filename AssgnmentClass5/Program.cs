using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace AssgnmentClass5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            int value = 0;

            Console.WriteLine("Input Value :");
            input = Console.ReadLine().ToString();
            string[] inputString = Regex.Split(input, @"\D+");

            foreach (var count in inputString)
            {
                if (count.All(Char.IsDigit) && !string.IsNullOrEmpty(count))
                    value = value + int.Parse(count);
                else
                    Console.WriteLine("Input string is not in correct format.");
            }

            Console.WriteLine("Output:" + value);
            Console.ReadLine();
        }
    }
}
