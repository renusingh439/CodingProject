using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProject
{
    internal class BuggyCode
    {
        //        You’re given the following buggy C# code that attempts to return all even numbers from a list and multiply them by 2. Fix the bugs.
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        //        var result = numbers.Where(n => n % 2 == 1).Select(n => n * 2).ToList();

        //        Console.WriteLine(String.Join(", ", result));  // Expected: 4, 8, 12
        //Tasks:
        //Fix the logic
        //Explain what was wrong and how you corrected it
       
        public static void Buggy()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            var result = numbers.Where(n => n % 2 == 0).Select(n => n * 2).ToList();

            Console.WriteLine(String.Join(", ", result));

        }
       //Solution :

        // issue is need to find the  even no from the list and then multiply it ny 2 , 
        //however in given logic in where clause it is detecting odd numbers ,
        //so the fix is where(n=>n%2==0) ,not where(n=>n%2==1)
    }
}
