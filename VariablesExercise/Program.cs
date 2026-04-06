namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string initialGreeting =  "Hello, World!";
            int xDays = 3;
            char letterOfTheDay = 'G';
            bool nah = false;
            double dub64 = 9001;
            decimal dec64 = 1000000;
            
            Console.WriteLine($"{initialGreeting} It has been {xDays} since your last visit.\nThe letter of the day is {letterOfTheDay}\n" +
                              $"You tell your magic 8-ball that the outlook for the day is good. It responds with \"Your assesment is {nah}.\"\n" +
                              $"Your power level today is {dub64} and you have a ransom demand of {dec64} dollars.\n");
        }
    }
}
