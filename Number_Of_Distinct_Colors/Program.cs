namespace Number_Of_Distinct_Colors
{
    internal class Program
    {
        /*
         * #3160
         *  You are given an integer limit and a 2D array queries of size n x 2.

            There are limit + 1 balls with distinct labels in the range [0, limit]. Initially, all balls are uncolored. For every query in queries that is of the form [x, y], you mark ball x with the color y. After each query, you need to find the number of colors among the balls.

            Return an array result of length n, where result[i] denotes the number of colors after ith query.

            Note that when answering a query, lack of a color will not be considered as a color.

 

            Example 1:

            Input: limit = 4, queries = [[1,4],[2,5],[1,3],[3,4]]

            Output: [1,2,2,3]

            Explanation:

            After query 0, ball 1 has color 4.
            After query 1, ball 1 has color 4, and ball 2 has color 5.
            After query 2, ball 1 has color 3, and ball 2 has color 5.
            After query 3, ball 1 has color 3, ball 2 has color 5, and ball 3 has color 4.
            Example 2:

            Input: limit = 4, queries = [[0,1],[1,2],[2,2],[3,4],[4,5]]

            Output: [1,2,2,3,4]

            Explanation:



            After query 0, ball 0 has color 1.
            After query 1, ball 0 has color 1, and ball 1 has color 2.
            After query 2, ball 0 has color 1, and balls 1 and 2 have color 2.
            After query 3, ball 0 has color 1, balls 1 and 2 have color 2, and ball 3 has color 4.
            After query 4, ball 0 has color 1, balls 1 and 2 have color 2, ball 3 has color 4, and ball 4 has color 5.
 

            Constraints:

            1 <= limit <= 109
            1 <= n == queries.length <= 105
            queries[i].length == 2
            0 <= queries[i][0] <= limit
            1 <= queries[i][1] <= 109
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int[] QueryResults(int limit, int[][] queries)
        {
            // result[i] is the number of colors after ith query.
            // after each query, see whether the new added color exists already.
            // if it does 

            var result = new int[queries.Length];
            var ballToColor = new Dictionary<int, int>();
            var colorCount = new Dictionary<int, int>();

            // looping through each query
            // the old color will be the existing color on that ball.
            // if new color is not old color, decrease the number of color because 
            // old color is replaced.  reduce the color count(the times of the color being used) for that color
            // increase the color count of the new color.
            // why do we want to keep the color count? because if color count is reduced to 0.
            // we want to eliminate the color from the dictionary
            // if we don't record the color count, there's no way of knowing whether the color should be removeed.
            for (int i = 0; i < queries.Length; i++)
            {
                // queries[i][0] is the x of [x, y]
                // queries[i][1] is the y of [x, y]
                int ball = queries[i][0];
                int newColor = queries[i][1];

                // Check if the ball had a previous color
                if (ballToColor.TryGetValue(ball, out int oldColor))
                {
                    if (oldColor != newColor)
                    {
                        // Decrease count of old color
                        colorCount[oldColor]--;
                        if (colorCount[oldColor] == 0)
                            colorCount.Remove(oldColor);

                        // Set new color
                        ballToColor[ball] = newColor;
                        if (!colorCount.ContainsKey(newColor))
                            colorCount[newColor] = 0;
                        colorCount[newColor]++;
                    }
                }
                else
                {
                    // First time coloring this ball
                    ballToColor[ball] = newColor;
                    if (!colorCount.ContainsKey(newColor))
                        colorCount[newColor] = 0;
                    colorCount[newColor]++;
                }

                // Number of distinct colors used
                result[i] = colorCount.Count;
            }

            return result;
        }

    }
}
