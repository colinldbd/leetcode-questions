using System.Text.RegularExpressions;

namespace LengthOfLastWord
{
    internal class LengthOfLastWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string s = "Hello     World";
            LengthOfLastWord3(s);
        }

        public static int LengthOfLastWord(string s)
        {
            string[] result = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return result[^1].Length;
        }
        //public static int LengthOfLastWord3(string s)
        //{
        //    int max = -1;
        //    s.Trim();

        //    // Won't work
        //    //String.Split in C# does not accept regular expressions directly in this way.
        //    //Your use of @"\s" is treated as a literal string to split on, not as a regex pattern. 
        //    string[] result = s.Split(@"\s");

        //    foreach (string s2 in result)
        //    {
        //        if (s2.Length > max) { max = s2.Length; }
        //    }

        //    return max;
        //}


        public static int LengthOfLastWord2(string s)
        {
            s = s.Trim();
            string[] result = Regex.Split(s, @"\s+");


            return result[^1].Length;
        }

        public static int LengthOfLastWord3(string s)
        {
            int i = s.Length - 1;
            int length = 0;

            while (i >= 0)
            {
                if (s[i] == ' ')
                {
                    i--;
                }
                else 
                {
                    break;
                }
            }
            while (i >= 0)
            {
                if (s[i] != ' ')
                {
                    i--;
                    length++;
                }
                else
                {
                    break;
                }
            }

            return length;
        }
    }
}
