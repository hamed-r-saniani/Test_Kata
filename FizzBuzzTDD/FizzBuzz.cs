using System.Collections.Generic;

namespace FizzBuzzTDD
{
    public class FizzBuzz
    {
        public static List<string> Start(int count)
        {
            var result = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                //if(i %15 == 0)
                //{
                //    result.Add("FizzBuzz");
                //}
                //else if(i %3 == 0)
                //{
                //    result.Add("Fizz");
                //}
                //else if(i %5 == 0)
                //{
                //    result.Add("Buzz");
                //}
                //else
                //{
                //    result.Add(i.ToString());
                //}
                var output = i % 3 == 0 ? "Fizz" : "";
                output += i % 5 == 0 ? "Buzz" : "";
                output += output == string.Empty ? i.ToString() : string.Empty;

                result.Add(output);
            }
            return result;
        }
    }
}
