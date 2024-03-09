namespace HIndex
{
    internal class HIndex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GetHIndex([11, 15]);
        }

        public static int GetHIndex(int[] citations)
        {
            citations = citations.Order().ToArray();

            int h = 0;
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations.Length - 1 - i >= citations[i] - 1)
                {
                    if (h < citations[i])
                        h = citations[i];
                }
                else
                {
                    if (h < citations.Length - i)
                    {
                        h = citations.Length - i;
                    }
                }
            }

            return h;
        }

        // Utilzing bucket sort.
        public static int GetHIndex2(int[] citations)
        {
            int[] buckets = new int[citations.Length + 1];

            foreach (int c in citations)
            {
                if (c >= citations.Length)
                {
                    buckets[citations.Length]++;
                }
                else
                {
                    buckets[c]++;
                }
            }

            int count = 0;
            for (int i = citations.Length; i >= 0; i--)
            {
                count += buckets[i];
                if (i <= count)
                {
                    return i;
                }
            }

            return 0;
        }

    }
}
