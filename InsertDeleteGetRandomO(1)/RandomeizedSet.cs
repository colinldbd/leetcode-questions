namespace InsertDeleteGetRandomO_1_
{
    internal class RandomeizedSet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        List<int> set = new List<int>();

        public RandomeizedSet()
        {

        }

        public bool Insert(int val)
        {
            if (!set.Contains(val))
            {
                set.Add(val);
                return true;
            }
            else return false;
        }

        public bool Remove(int val)
        {
            if (set.Contains(val))
            {
                set.Remove(val);
                return true;
            }
            else return false;
        }

        public int GetRandom()
        {
            Random random = new Random();
            int index = random.Next()%set.Count;

            return set[index];
        }
    }
    /**
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}

