using System;
using System.Linq;

namespace Minimum_Limit_of_Balls_in_a_Bag
{
  class Program
  {
    static void Main(string[] args)
    {

      var nums = new int[] { 2, 4, 8, 2 };
      var maxOperations = 4;
      Solution s = new Solution();
      var answer = s.MinimumSize(nums, maxOperations);
      Console.WriteLine(answer);
    }
  }

  public class Solution
  {
    public int MinimumSize(int[] nums, int maxOperations)
    {
      int l = 1;
      int r = nums.Max();
      int res = r;
      while (l < r)
      {
        int mid = l + (r - l) / 2;
        int oprs = 0;
        for (int i = 0; i < nums.Length; i++)
        {
          if (nums[i] > mid)
          {
            if (nums[i] % mid == 0)
            {
              oprs += (nums[i] / mid) - 1;
            }
            else
            {
              oprs += nums[i] / mid;
            }
          }
        }
        if (oprs <= maxOperations)
        {
          res = mid;
          r = mid;
        }
        else
        {
          l = mid + 1;
        }
      }

      return res;
    }
  }
} 
