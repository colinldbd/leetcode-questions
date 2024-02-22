using System.Security;

namespace LongestCommonPrefix
{
    internal class LongestCommonPrefix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            LongestCommonPrefix2(["", "b"]);
        }

        public static string LongestCommonPrefix(string[] strs)
        {

            //Find the shortest string, and use it as the base line to test all strings.
            // Though not the most efficient way though.
            int minLength = 100000000;
            string minStr = string.Empty;
            bool isCommon = true;

            string chars = "";

            foreach (string s in strs)
            {
                if (s.Length < minLength)
                {
                    minLength = s.Length;
                    minStr = s;
                }
            }

            for (int i = 0; i < minLength; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] != minStr[i])
                    {
                        isCommon = false;
                        break;
                    }
                }

                if (isCommon)
                {
                    chars = chars + minStr[i];
                }
                else
                {
                    break;
                }
            }

            return chars;

        }

        // Sort the list first, only the ones towards the end might have character that is not in a common prefix.
        // So if the last string has commonPrefix characters then all strings must have it.
        // You only need to compare the first and the last.
        public static string LongestCommonPrefix2(string[] strs)
        {
            string commonPrefix = "";

            strs = [.. strs.Order()];
            //Array.Sort(strs);

            int minLength = strs[0].Length > strs[^1].Length ? strs[^1].Length : strs[0].Length;

            for (int i = 0; i < minLength; i++)
            {
                if (strs[0][i] != strs[^1][i])
                {
                    break;
                }

                commonPrefix += strs[0][i];
            }

            return commonPrefix;
        }

    }
}
