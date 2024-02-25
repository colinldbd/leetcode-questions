namespace IsIsomorphic
{
    internal class IsIsomorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            bool result = Isomorphic("add", "egg");

            return;
        }

        public static bool Isomorphic(string s, string t)
        {
            Dictionary<char, int> sdict = new Dictionary<char, int>();
            Dictionary<char, int> tdict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!sdict.ContainsKey(s[i]))
                {
                    sdict.Add(s[i], i);
                }
                if (!tdict.ContainsKey(t[i]))
                {
                    tdict.Add(t[i], i);
                }

                // The character at the same position in the string in each string should be map to same index(value) in their
                // respective dictionary. And all same characters should be mapped to the same index(value) in the dictionary.
                // For example, "add" and "egr", 'a' will be mapped to 0, 'e' will be mapped to 0, this can represent
                // their structure in the string. But when  the third 'd' is mapped to 1 in dict 1, the thrid 'r' will be mapped
                // to 2 in dict 2. And that is no isomorphic.
                // Can also be interpreted as the same characters will be grouped into the same index, and the index is recored as
                // the order it appeared, so the same characters will be bound to their index as the iteration on the string 
                // continues. So if at the same iteration, the character in respective string appears in a different order, their
                // structure will not be the same.
                if (sdict[s[i]] != tdict[t[i]])
                    return false;
            }

            //it's like mapping "add" into 01，"egg" into 01. But "egc" will be mapped into 012
            return true;
        }
    }
}
