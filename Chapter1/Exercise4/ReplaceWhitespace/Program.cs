﻿using System;
using System.Linq;
using System.Text;

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
        	var builder = new StringBuilder();
        	foreach(var c in s.Trim().ToCharArray()){
        		if(c == ' ')
        			builder.Append("%20");
        		else
        			builder.Append(c);
        	}
        	return builder.ToString();
        }

        static string ReplaceWhitespaceWithLinq(string s)
        {
        	return string.Join("%20", s.Trim().Split()).ToString();
        }

        static string ReplaceWhitespaceWithOneLoop(string s)
        {
        	var arrayC = s.Trim().ToCharArray();
        	var newSpaces = arrayC.Count(c => c == ' ');
        	var newArray = new char[arrayC.Length() + newSpaces];
        	for(var i = 0; i < arrayC.Length(); i++)
        	{
        		if(arrayC[i] == ' ')
        		{

        		}
        		else
        		{

        		}

        	}
        		
        }
    }
}
