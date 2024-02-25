namespace WordPattern
{
    internal class WordPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SolveWordPattern("abba", "dog cat cat dog");
        }

        public static bool SolveWordPattern(string pattern, string s)
        {
            string[] sArray = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char, int> pDict = new Dictionary<char, int>();
            Dictionary<string, int> sDict = new Dictionary<string, int>();

            if (pattern.Length != sArray.Length) return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!pDict.ContainsKey(pattern[i]))
                {
                    pDict[pattern[i]] = i;
                }
                if (!sDict.ContainsKey(sArray[i]))
                {
                    sDict[sArray[i]] = i;
                }

                if (pDict[pattern[i]] != sDict[sArray[i]])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
