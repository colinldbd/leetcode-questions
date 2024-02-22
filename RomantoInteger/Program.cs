namespace RomantoInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int RomanToInt(string s)
        {
            Dictionary<char, int> roman = new Dictionary<char, int>();
            int total = 0;

            roman.Add('I', 1);
            roman.Add('V', 5);
            roman.Add('X', 10);
            roman.Add('L', 50);
            roman.Add('C', 100);
            roman.Add('D', 500);
            roman.Add('M', 1000);

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (roman[s[i]] < roman[s[i + 1]])
                {
                    total -= roman[s[i]];
                }
                else
                {
                    total += roman[s[i]];
                }
            }

            // ^1 means the last index, a C# .0 feature. ^2 means the second to last.
            return total + roman[s[^1]];
        }

        public int RomanToInt2(string s)
        {
            Dictionary<char, int> roman = new Dictionary<char, int>();
            int sum = 0;

            roman.Add('I', 1);
            roman.Add('V', 5);
            roman.Add('X', 10);
            roman.Add('L', 50);
            roman.Add('C', 100);
            roman.Add('D', 500);
            roman.Add('M', 1000);

            s = s.Replace("IV", "IIII");
            s = s.Replace("IX", "VIIII");
            s = s.Replace("XL", "XXXX");
            s = s.Replace("XC", "LXXXX");
            s = s.Replace("CD", "CCCC");
            s = s.Replace("CM", "DCCCC");

            for (int i = 0; i < s.Length; i++)
            {
                sum = sum + (roman.GetValueOrDefault(s[i]));
            }

            return sum;
        }
    }
}
