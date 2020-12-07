using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsUnique
{
    /// <summary>
    /// The purpose of this app is to provide different algorithms seeing if the characters in the string are unique.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Is this string unique?";

            Console.WriteLine($"String is Unique: {isUnique1(s)}");
        }

        /// <summary>
        /// Very simple solution. Uses only one data structure. Iterates through the string
        /// twice. The check does not take into consideration case. This may only use one data structure (array)
        /// but is ineficient of O(n2). If the string was 2GB then creating a new data structure is better.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static bool isUnique1(string s)
        {
            foreach(char c in s)
            {
                int charcount = 0;
                for(int x = 0; x<s.Length; x++)
                {
                    if (c == s[x])
                    {
                        charcount++;
                        if (charcount >= 2)
                        {
                            Console.WriteLine($"Failure occurs at char: {c} index: {x}");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Create a new data structure and see if the char exists before adding it and the count
        /// to the data structure. A Hashtable works if you would like to keep count. But this 
        /// situation is not necessary so an ArrayList or a List<char> would work as well.
        /// O(N)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static bool isUnique2(string s)
        {
            Hashtable ht = new Hashtable();

            foreach (var c in s)
            {
                if (ht.ContainsKey(c))
                    return false;
                else
                    ht.Add(c, 1);
            }
            return true;
        }
    }
}
