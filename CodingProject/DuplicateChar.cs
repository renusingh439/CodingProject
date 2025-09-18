using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProject
{
    internal class DuplicateChar
    {
        static List<char> FindDuplicateCharacters(string s)
        {
            Dictionary<char, int> occurance = new Dictionary<char, int>();
            List<char> duplicateValues = new List<char>();

            foreach (char c in s)
            {
                if (occurance.ContainsKey(c))
                {
                    occurance[c]++;
                    duplicateValues.Add(c);
                }
                else
                {
                    occurance[c] = 1;
                }
            }
            return duplicateValues;
        }

        public static void DuplicateCharFind() 
        {
            Console.WriteLine("Enter the input string: ");
            string s = Console.ReadLine();
            //Detect Duplicate Characters in a String
            List<char> duplicatechar = FindDuplicateCharacters(s);
            foreach (char c in duplicatechar)
            {
                Console.Write("'" + c + "' ");
            }
        }
       
}
}
