namespace RansomNote
{
    internal class RansomNote
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            canConstruct("a", "b");
        }

        public static bool canConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> r = new Dictionary<char, int>();
            Dictionary<char, int> mag = new Dictionary<char, int>();


            foreach (char c in ransomNote)
            {
                if (!r.ContainsKey(c))
                {
                    r.Add(c, 0);
                }
                r[c]++;
            }
            foreach (char c in magazine)
            {
                if (!mag.ContainsKey(c))
                {
                    mag.Add(c, 0);
                }
                mag[c]++;
            }

            foreach (char c in ransomNote)
            {
                if (!mag.ContainsKey(c))
                    return false;
                if (r[c] > mag[c])
                    return false;
            }

            return true;
        }

        public static bool canConstruct2(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length) return false;
            int[] alphabets_counter = new int[26];

            foreach (char c in magazine)
                alphabets_counter[c - 'a']++;

            foreach (char c in ransomNote)
            {
                if (alphabets_counter[c - 'a'] == 0) return false;
                alphabets_counter[c - 'a']--;
            }
            return true;
        }

        public bool CanConstruct3(string ransomNote, string magazine)
        {
            foreach (char i in ransomNote)
            {
                if (!magazine.Contains(i))
                {
                    return false;
                }
                else
                {
                    magazine = magazine.Remove(magazine.IndexOf(i), 1);
                }
            }
            return true;
        }
    }
}
