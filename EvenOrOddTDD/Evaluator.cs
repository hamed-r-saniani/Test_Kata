namespace EvenOrOddTDD
{
    public class Evaluator
    {
        public static string Evaluate(int number)
        {
            //if (number %2 == 0)
            //{
            //    return "Even";
            //}
            //return "Odd";

            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}