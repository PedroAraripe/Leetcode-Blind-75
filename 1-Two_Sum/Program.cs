using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine($"\n=====> Quais os indexes do array que somados resultam no valor alvo?");

          int[] t1List = {2, 7, 11, 15};
          int t1Target = 9;
          int[] t1Result = TwoSum(t1List,  t1Target);
          Console.WriteLine($"{t1Result[0]} e {t1Result[1]}");

          int[] t2List = {3, 2, 4};
          int t2Target = 6;
          int[] t2Result = TwoSum(t2List,  t2Target);
          Console.WriteLine($"{t2Result[0]} e {t2Result[1]}");

          int[] t3List = {3, 3};
          int t3Target = 6;
          int[] t3Result = TwoSum(t3List,  t3Target);
          Console.WriteLine($"{t3Result[0]} e {t3Result[1]}");
        }

        static int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> mapedIntsIndex = new Dictionary<int, int>();
            
            for(int i=0; i<nums.Length; i++) {
              int complement = target - nums[i];

              // Searching if we can find the matching number index to sum to target
              if(mapedIntsIndex.ContainsKey(complement)) {
                return new int[] { mapedIntsIndex[complement],i };
              }
              
              // Populating dictionary with nums and respective indexes
              mapedIntsIndex[nums[i]] = i;
            }

            return new int[0];
        }
    }
}