namespace LeetCode.Problems.Stack
{
    public class ValidParentheses
    {
        private static readonly Dictionary<char, char> OpenToClosedParenthesesMap = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };

        /// <summary>
        /// Given a string <paramref name="s"/> containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        /// <br/>
        /// An input string is valid if:
        /// <br/>
        /// 1. Open brackets must be closed by the same type of brackets.
        /// <br/>
        /// 2. Open brackets must be closed in the correct order.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Solve(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (OpenToClosedParenthesesMap.TryGetValue(c, out var beginingParenthese) && stack.TryPeek(out var lastChar))
                {
                    if (lastChar == beginingParenthese)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return !stack.Any();
        }
    }
}
