namespace LeetCode.Problems.Arrays
{
    public class TwoSum
    {
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
