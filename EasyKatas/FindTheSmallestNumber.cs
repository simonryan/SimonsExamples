using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyKatas
{
    static class FindTheSmallestNumber
    {
        public static float? GetSmallestValueV1(float[] nums)
        {
            if (nums != null && nums.Length > 0)
            {
                float smallest = nums[0];
                for (var i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < smallest)
                    {
                        smallest = nums[i];
                    }
                }

                return smallest;
            }
            return null;
        }

        public static float GetSmallestValueV2(float[] nums)
        {
            if (nums != null && nums.Length > 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return nums.Min();
        }
    }
}
