using System;

namespace MoodAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");
            analyseMood obj = new analyseMood();
            obj.message = "happy";
            Console.WriteLine(obj.AnalysingMood());
        }
    }
}

