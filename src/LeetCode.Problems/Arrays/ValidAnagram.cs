namespace LeetCode.Problems.Arrays
{
    public class ValidAnagram
    {
        /// <summary>
        /// Given two strings <paramref name="s"/> and <paramref name="t"/>, return <c>true</c> if t is an anagram of s, and <c>false</c> otherwise.
        /// <br />
        /// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns><c>true</c> if t is an anagram of s, and <c>false</c> otherwise.</returns>
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
