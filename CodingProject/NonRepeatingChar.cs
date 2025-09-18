using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CodingProject
{
    internal class NonRepeatingChar
    {
        public static char? FirstUniqueCharacter(string input)
        {
            var charCount = new Dictionary<char, int>();

            // Count frequency of each character
            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            // Find first character with count = 1
            foreach (char c in input)
            {
                if (charCount[c] == 1)
                    return c;
            }

            return null; // no unique character
        }
        public static void FirstNonRepition() 
        {
            Console.WriteLine("Enter the input string:");
            string s= Console.ReadLine();
            char? output = FirstUniqueCharacter(s);
            Console.WriteLine(output);
           
        }

    }
}
