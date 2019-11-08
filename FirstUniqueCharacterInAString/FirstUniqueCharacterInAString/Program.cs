using System;
using System.Collections.Generic;

namespace FirstUniqueCharacterInAString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int FirstUniqueCharacter(string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int k = 0; k < s.Length; ++k)
            {
                if(dictionary.TryGetValue(s[k], out int value))
                {
                    dictionary[s[k]] = value + 1;
                }
                else
                {
                    dictionary.Add(s[k], 1);
                }
            }
            for (int k = 0; k < s.Length; ++k)
            {
                if (dictionary.TryGetValue(s[k], out int value))
                {
                    if(value == 1)
                    {
                        return k;
                    }
                }
            }
            return -1;
        }
    }
}
