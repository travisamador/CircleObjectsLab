using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectsLab
{
    internal static class Validator
    {
        public static double Double()
        {
            while (true)
            {
                try
                {
                    double num = double.Parse(Console.ReadLine());
                    return num;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + "Try again.");
                }
            }
        }

        public static string YesOrNo()
        {
            while (true)
            {
                try
                {
                    string answer = Console.ReadLine().Trim().ToLower();
                    if (answer != "y" && answer != "n")
                    {
                        throw new Exception("Answer not accepted. Please enter y or n.");
                    }
                    return answer;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
