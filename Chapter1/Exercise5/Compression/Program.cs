using System;

namespace Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compress string!");
            Console.WriteLine("Enter string to compress");
            var input = Console.ReadLine();
            while(input != "quit")
            {
            	Console.WriteLine(Compress(input));
            	input = Console.ReadLine();
            }
        }

        static string Compress(string s)
        {
        	var arrayC = s.ToCharArray();
        	var result = new char[s.Length];
        	var resultIndex = 0;
        	var countOfChar = 0;
        	for(var i = 0; i <  s.Length - 1; i++)
        	{
        		if(arrayC[i] != arrayC[i + 1])
        		{
        			result[resultIndex] = arrayC[i];
        			result[resultIndex + 1] = countOfChar;
        			resultIndex = resultIndex + 2;
        			countOfChar = 1;
        		}
        		else
        			countOfChar++;
        	}
        	
        	return (s.Length <= (resultIndex + 1 ))? s : result.ToString();
        }
    }
}
