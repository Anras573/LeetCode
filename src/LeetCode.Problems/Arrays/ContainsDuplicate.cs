namespace LeetCode.Problems.Arrays
{
    public class ContainsDuplicate
    {
        public bool Solve(int[] input)
        {
            var hashSet = new HashSet<int>();

            foreach (var num in input)
            {
                if (!hashSet.Add(num))
                    return true;
            }

            return false;
        }
    }
}
