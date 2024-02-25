namespace IsSubsequence
{
    internal class IsSubsequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static bool Subsequence(string s, string t)
        {
            string result = "";

            if (t.Length < s.Length) return false;

            for (int i = 0, j = 0; j < t.Length && i < s.Length; j++)
            {
                if (t[j] == s[i])
                {
                    result += t[j];
                    i++;
                }
            }

            if (result == s)
                return true;
            else
                return false;
        }
    }
}
