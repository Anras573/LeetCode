namespace LeetCode.Problems.Arrays;

public class GroupAnagrams
{
    /// <summary>
    /// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
    ///<para>
    /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    /// </para>
    /// <example>
    /// Example 1:
    /// Input: strs = ["eat","tea","tan","ate","nat","bat"]
    /// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
    /// 
    /// Example 2:
    /// Input: strs = [""]
    /// Output: [[""]]
    /// 
    /// Example 3:
    /// Input: strs = ["a"]
    /// Output: [["a"]]
    /// </example>
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public List<List<string>> Solve(string[] strs)
    {
        var result = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var key = new string(str.OrderBy(s => s).ToArray());

            if (result.TryGetValue(key, out var value))
            {
                value.Add(str);
            }
            else
            {
                result.Add(key, new List<string> { str });
            }
        }

        return result.Values.ToList();
    }
}