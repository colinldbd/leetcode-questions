namespace HappyNumber
{
    internal class HappyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public bool IsHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();

            while(n != 1)
            {
                if (set.Contains(n))
                {
                    return false;
                }

                set.Add(n);
                int sum = 0;
                char[] chars = n.ToString().ToCharArray();
                foreach(char c in chars)
                {
                    int i = (int)Char.GetNumericValue(c);
                    sum += i * i;
                }
                n = sum;
            }
            return true;
        }

        // Floyd's tortoise and hare method
        // One pointer is slow and one pointer is fast, because we are trying to 
        // detect loop, if there's a loop eventually slow and fast will come to the
        // same result, and if it's not 1, then there's a loop in this algorithm and is not happy.
        public bool isHappy2(int n)
        {

            int slow = n;
            int fast = n;
            //while loop is not used here because initially slow and 
            //fast pointer will be equal only, so the loop won't run.
            do
            {
                //slow moving one step ahead and fast moving two steps ahead

                slow = square(slow);
                fast = square(square(fast));
            } while (slow != fast);

            //if a cycle exists, then the number is not a happy number
            //and slow will have a value other than 1

            return slow == 1;
        }

        //Finding the square of the digits of a number

        public int square(int num)
        {

            int ans = 0;

            while (num > 0)
            {
                int remainder = num % 10;
                ans += remainder * remainder;
                num /= 10;
            }

            return ans;
        }
    }
}
