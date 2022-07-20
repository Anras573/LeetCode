namespace LeetCode.Problems.Arrays
{
    public class TwoSum
    {
        /// <summary>
        /// Given an array of integers <paramref name="nums"/> and an integer <paramref name="target"/>, return indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>indices of the two numbers such that they add up to target.</returns>
        public int[] Solve(int[] nums, int target)
        {
            var indicesDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var remaining = target - nums[i];

                if (indicesDictionary.TryGetValue(remaining, out var index))
                {
                    return new[] { index, i };
                }

                indicesDictionary[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}
