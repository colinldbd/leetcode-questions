namespace BestTimetoBuyandSellStockII
{
    internal class BestTimetoBuyandSellStockII
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /* We have two solutions for this problem.
         When adding the profit, the profit between 2 dates can catagorized as:
         (1) there's period of decreasing between the 2 dates.
          in this case, you can ignore those decreasing period and adds those increasing period,
          and the profit will be maximum.
         (2) for each of the increasing period, the maximum profit is always the ending date - beginning date.
          and its always the sum of all the neighbouring days adding up.
          1, 3, 4, 8, 9
          the maximum profit is 9 - 1 = 8 and it equls to 3-1 + 4-3 + 8-4 + 9-8
          so you don't need to record the lowest and height date in that period, just adding up all the intervals.
        */
        public int MaxProfit2(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += (prices[i] - prices[i - 1]);
                }
            }

            return profit;
        }

        // use DP
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int[] profits = new int[prices.Length];

            profits[0] = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                profits[i] = profits[i - 1] + Math.Max(prices[i] - prices[i - 1], 0);
            }

            return profits[prices.Length - 1];
        }
    }
}
