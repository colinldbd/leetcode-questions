namespace PalindromeNumber
{
    internal class PalindromeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            string number = x.ToString();
            Char[] chars = number.ToCharArray();
            Array.Reverse(chars);

            string reverse =  new(chars);

            return reverse == number;
        }
    }
}
