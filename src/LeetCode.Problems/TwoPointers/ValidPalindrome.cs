﻿namespace LeetCode.Problems.TwoPointers
{
    public class ValidPalindrome
    {
        /// <summary>
        /// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
        /// <br/>
        /// Given a string <paramref name="s"/>, return <c>true</c> if it is a palindrome, or <c>false</c> otherwise.
        /// </summary>
        /// <param name="s"></param>
        /// <returns><c>true</c> if it is a palindrome, or <c>false</c> otherwise.</returns>
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
