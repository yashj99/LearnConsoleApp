using System;

namespace LearnConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ##### Get String Length ##### ");
            Console.WriteLine("Please enter a string : ");
            LearnHelper lh = new LearnHelper();
            string enteredString = Console.ReadLine();
            Console.WriteLine("Length of " + enteredString + " is  : " + lh.findLength(enteredString));

            Console.ReadKey();
        }
    }
    public class LearnHelper
    {
        public int findLength(string s)
        {
            return s.Trim().Length;
        }
    }
}
