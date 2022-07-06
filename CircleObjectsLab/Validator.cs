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
                    if(num < 0)
                    {
                        throw new Exception("Radius cannot be negative. Try Again.");
                    }
                    return num;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + "Try again.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
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
