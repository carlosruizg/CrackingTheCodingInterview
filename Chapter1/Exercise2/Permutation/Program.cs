using System;
using System.Linq;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Permutations!");
            Console.WriteLine("First Word");
            var input1 = Console.ReadLine();
            Console.WriteLine("Second Word");
            var input2 = Console.ReadLine();
            while(input1 != "quit")
            {
            	Console.WriteLine($"Are {input1} and {input2} permutations? {IsPermutationWithSorts(input1, input2)}");
	            Console.WriteLine("First Word");
	            input1 = Console.ReadLine();
	            Console.WriteLine("Second Word");
	            input2 = Console.ReadLine();
             }
        }

        static bool IsPermutation(string s1, string s2)
        {
        	if(s1.Length != s2.Length)
        		return false;

        	var charsInString = new int[256];
        	foreach(var c in s1.ToCharArray())
        	{

        		charsInString[(int)c]++;
        	}

        	foreach(var c in s2.ToCharArray())
        	{
        		if(--charsInString[(int)c] < 0)
        			return false;
        	}

        	return true;
        }

        static bool IsPermutationWithSorts(string s1, string s2)
        {
        	if(s1.Length != s2.Length)
        		return false;

        	var sortedS1 = new string(s1.OrderBy(c => c).ToArray());
        	var sortedS2 = new string(s2.OrderBy(c => c).ToArray());

        	return sortedS1 == sortedS2;
        }
    }
}
