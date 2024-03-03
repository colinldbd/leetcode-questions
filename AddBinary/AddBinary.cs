namespace AddBinary
{
    internal class AddBinary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AddBinaryString2("1010", "1011");
        }


        //Can't convert, will pass the limit for integer.
        public static string AddBinaryString(string a, string b)
        {
            long sum = ToDeximal(a) + ToDeximal(b);
            string binary = string.Empty;
            string reverse = string.Empty;

            do
            {
                binary += (sum % 2).ToString();
                sum /= 2;
            } while (sum != 0);

            for (int i = 0; i < binary.Length; i++)
            {
                reverse += binary[binary.Length - i - 1];
            }

            return reverse;
        }

        public static long ToDeximal(string binary)
        {
            if (binary == null || binary == String.Empty)
            {
                return 0;
            }
            long num = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                num += (long)Char.GetNumericValue(binary[binary.Length - i - 1]) * (long)Math.Pow(2, i);

            }

            return num;
        }

        public static string? AddBinaryString2(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;

            string result = string.Empty;

            while (i >= 0 || j >= 0)
            {
                int sum = 0;
                sum += carry;
                //int sum = carry;
                // Don't write as (int)a[i--], it will reture the ASCII number
                if (i >= 0)
                    sum += (int)Char.GetNumericValue(a[i--]);
                if (j >= 0)
                    sum += (int)Char.GetNumericValue(b[j--]);
                carry = sum > 1 ? 1 : 0;
                result += (sum % 2);
            }

            if (carry != 0) { result += carry; }

            char[] cArray = result.ToCharArray();
            Array.Reverse(cArray);

            result = new string(cArray);

            return result;
        }
    }
}
