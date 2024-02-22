namespace IndexofTheFirstOccurenceInString
{
    internal class IndexofTheFirstOccurenceInString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                string[] result = haystack.Split(needle, StringSplitOptions.None);

                return result[0].Length;
            }

            return -1;
        }

        public int StrSt2(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }

        // Or try to loop through the occurrence of needle in haystack
        //public int StrSt2(string haystack, string needle)
        //{
        //    return haystack.IndexOf(needle);
        //}

        // Or by using substring
        public int StrStr3(string haystack, string needle)
        {
            if (needle.Length > haystack.Length)
            {
                return -1;
            }
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, i + needle.Length).Equals(needle))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
