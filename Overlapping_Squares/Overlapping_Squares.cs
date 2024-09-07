namespace Overlapping_Squares
{
    internal class Overlapping_Squares
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string Overlapping(string[] strArr)
        {
            // Step 1: Parse the input strings to get coords
            int n = strArr.Length;
            int[][] coords = strArr.Select(s => s.Split(',').Select(int.Parse).ToArray()).ToArray();

            // Define the side length based on the number of squares
            int sideLength = n;

            // Step 2: Calculate the bounds for each square (top-left and bottom-right corners)
            int minX = coords.Max(c => c[0]);
            int minY = coords.Max(c => c[1]);
            int maxX = coords.Min(c => c[0]) + sideLength;
            int maxY = coords.Min(c => c[1]) + sideLength;

            // Step 3: Calculate the overlapping width and height
            int overlapWidth = maxX - minX;
            int overlapHeight = maxY - minY;

            // Step 4: If there is no overlap, return "0"
            if (overlapWidth <= 0 || overlapHeight <= 0)
            {
                return "0";
            }

            // Step 5: Otherwise, return the overlapping area
            int overlapArea = overlapWidth * overlapHeight;
            return overlapArea.ToString();
        }
    }
}
