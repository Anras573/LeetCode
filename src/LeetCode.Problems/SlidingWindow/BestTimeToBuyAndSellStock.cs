namespace LeetCode.Problems.SlidingWindow
{
    public class BestTimeToBuyAndSellStock
    {
        /// <summary>
        /// You are given an array prices where <c>prices[i]</c> is the price of a given stock on the ith day.
        /// <br/>
        /// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        /// <br/>
        /// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns>the maximum profit you can achieve from this transaction. If you cannot achieve any profit, returns 0.</returns>
        public int Solve(int[] prices)
        {
            var maxProfit = 0;
            var left = 0; // buy
            var right = 1; // sell

            while(right < prices.Length)
            {
                if (prices[left] < prices[right])
                {
                    var profit = prices[right] - prices[left];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                {
                    left = right;
                }

                right++;
            }

            return maxProfit;
        }
    }
}
