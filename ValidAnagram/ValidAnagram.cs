namespace ValidAnagram
{
    internal class ValidAnagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> d1 = new Dictionary<char, int>();
            Dictionary<char, int> d2 = new Dictionary<char, int>();

            if (s.Length != t.Length) return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!d1.ContainsKey(s[i]))
                {
                    d1[s[i]] = 0;
                }
                if (!d2.ContainsKey(t[i]))
                {
                    d2[t[i]] = 0;
                }
                d1[s[i]]++;
                d2[t[i]]++;
            }

            if(d1.Count() != d2.Count()) { return false; }
            foreach(char c in s)
            {
                if (!d2.Keys.Contains(c))
                {
                    return false;
                }
                if (d1[c] != d2[c])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
