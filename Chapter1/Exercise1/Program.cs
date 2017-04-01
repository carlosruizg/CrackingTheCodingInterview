using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is Word Unique?");
            var input = Console.ReadLine();
            while(input != "quit"){
            	Console.WriteLine("Enter word");
            	Console.WriteLine($"Is Unique: {UsUniqueBinary(input)}");
            	input = Console.ReadLine();
            }
        }

        static private bool IsUnique(string s)
        {
        	if(s.Length > 256)
        		return false;

        	var existCharacter = new bool[256];
        	foreach(var character in s.ToCharArray()){
        		if(existCharacter[(int)character])
        			return false;

        		existCharacter[(int)character] = true;
        	}
        	return true;
        }

        // Supossing only lowercase letters
        static private bool UsUniqueBinary(string s)
        {
        	int exist = 0;
        	foreach( var c in s.ToCharArray())
        	{
        		if((exist & (1 << (int)c)) > 0)
        		{
        			return false;
        		}
        		exist |= 1 << (int)c;
        	}
        	return true;
        }
    }
}
