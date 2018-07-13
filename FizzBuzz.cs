
using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GenerateFizzBuzzResults(int input)
        {
            if (input < 0)
            {
                throw new ArgumentException("Input value must be positive");
            }

            if (input == 0)
            {
                throw new ArgumentException("Input value must be greater than 0");
            }

            string result = "";
            
            for (int i = 1; i <= input; i++)
            {
                var isSquaredNumber = Math.Sqrt(double.Parse(i.ToString())) % 1 == 0;

                if (i % 3 == 0 && i % 5 == 0 && isSquaredNumber)
                {
                    result += "FizzBuzzBang,";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    result += "FizzBuzz,";
                }
                else
                {
                    if (i % 3 == 0 && isSquaredNumber)
                    {
                        result += "FizzBang,";
                    }
                    else if (i % 5 == 0 && isSquaredNumber)
                    {
                        result += "BuzzBang,";
                    }
                    else if (i % 3 == 0)
                    {
                        result += "Fizz,";
                    }
                    else if (i % 5 == 0)
                    {
                        result += "Buzz,";
                    }
                    else if (isSquaredNumber)
                    {
                        result += "Bang,";
                    }
                    else
                    {
                        result += i + ",";
                    }
                }
            }

            return result.TrimEnd(',');
        }
    }
}
