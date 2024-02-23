using System.Reflection.PortableExecutable;

namespace IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            bool result = IsPalindrome("a.");

            return;
        }

        public static bool IsPalindrome(string s)
        {
            string cleanString = "";
            string reverseString = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (char.IsLetterOrDigit(s[i]))
                {
                    reverseString += s[i];
                }
                if (char.IsLetterOrDigit(s[s.Length - i - 1]))
                {
                    cleanString += s[s.Length - i - 1];
                }

            }

            reverseString = reverseString.ToLower();
            cleanString = cleanString.ToLower();

            return reverseString.Equals(cleanString);
        }

        public static bool IsPalindrome2(string s)
        {
            int l = 0, r = s.Length - 1;
            s = s.ToLower();
            while (l < r)
            {
                while (l < r && (s[l] < 'a' || s[l] > 'z') && (s[l] < '0' || s[l] > '9'))
                    l++;
                while (l < r && (s[r] < 'a' || s[r] > 'z') && (s[r] < '0' || s[r] > '9'))
                    r--;
                if (s[l] != s[r])
                    return false;
                l++;
                r--;
            }
            return true;
        }
    }
}
