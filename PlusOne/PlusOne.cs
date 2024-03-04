namespace PlusOne
{
    internal class PlusOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] GetPlusOne(int[] digits)
        {
            int carry = 1;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] + carry == 10)
                {
                    carry = 1;
                    digits[i] = 0;
                }
                else
                {
                    digits[i] += carry;
                    carry = 0;
                }
            }

            List<int> ints = digits.ToList();

            if (carry == 1)
            {
                ints.Insert(0, carry);
                return ints.ToArray();
            }
            else
            {
                return digits;
            }

            //for (int i = digits.length - 1; i >= 0; i--)
            //{
            //    if (digits[i] < 9)
            //    {
            //        digits[i]++;
            //        return digits;
            //    }
            //    digits[i] = 0;
            //}

            //digits = new int[digits.length + 1];
            //digits[0] = 1;
            //return digits;
        }
    }
}
