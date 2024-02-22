namespace BestTimetoBuyandSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // Time limited exceeded? Brute force.
        public int MaxProfit(int[] prices)
        {
            int max = -10000000;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > max)
                    {
                        max = prices[j] - prices[i];
                    }
                }
            }

            if (max > 0)
            {
                return max;
            }
            else
            {
                return 0;
            }
        }

        //Sliding window technique.
        // Imaging the price set is a window, we expand the window to the right and find
        // the cheapest price in the window, we don't need to compare all the prices, just compare 
        // current price to the cheapest price and calculte its difference, and find the best profit
        public int MaxProfit2(int[] prices)
        {
            int max = -10000000;

            int minPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (minPrice > prices[i])
                {
                    minPrice = prices[i];
                }

                if (prices[i] - minPrice > max)
                {
                    max = prices[i] - minPrice;
                }
            }

            if (max > 0) return max;
            else return 0;


        }

    }
}
