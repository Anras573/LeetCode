namespace LeetCode.Problems.TwoPointers
{
    public class ValidPalindrome
    {
        public bool Solve(string s)
        {            
            var left = 0;
            var right = s.Length - 1;

            while(left < right)
            {
                while (left < right && !IsAlphaNumeric(s[left]))
                {
                    left++;
                }
                
                while (right > left && !IsAlphaNumeric(s[right]))
                {
                    right--;
                }

                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        private static bool IsAlphaNumeric(char c)
        {
            return char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c);
        }
    }
}
