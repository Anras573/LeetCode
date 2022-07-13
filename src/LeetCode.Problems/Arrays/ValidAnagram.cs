namespace LeetCode.Problems.Arrays
{
    public class ValidAnagram
    {
        public bool Solve(string s, string t)
        {
            var sArray = s.ToCharArray();
            Array.Sort(sArray);

            var tArray = t.ToCharArray();
            Array.Sort(tArray);

            return sArray.SequenceEqual(tArray);
        }
    }
}
