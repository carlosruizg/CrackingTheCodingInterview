using System;
using System.Linq;

namespace ReplaceWhitespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Replace Whitespaces!");
            Console.WriteLine("Enter Word");
            var input = Console.ReadLine();
            while(input != "quit")
            {
            	Console.WriteLine(ReplaceWhitespace(input));
            	input = Console.ReadLine();
            }
        }

        static string ReplaceWhitespace(string s)
        {
        	return string.Join("%20", s.Trim().Split()).ToString();
        }
    }
}
