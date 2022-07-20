namespace LeetCode.Problems.Arrays
{
    public class ContainsDuplicate
    {
        /// <summary>
        /// Given an integer array <paramref name="nums"/>, return <c>true</c> if any value appears at least twice in the array, and return <c>false</c> if every element is distinct.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns><c>true</c> if any value appears at least twice in the array, and <c>false</c> if every element is distinct.</returns>
        public bool Solve(int[] nums)
        {
            var hashSet = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!hashSet.Add(num))
                    return true;
            }

            return false;
        }
    }
}
