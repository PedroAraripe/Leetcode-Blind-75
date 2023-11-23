using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int[] t1List = {2, 7, 11, 15};
          int t1Target = 9;

          int[] t2List = {3, 2, 4};
          int t2Target = 6;

          int[] t3List = {3, 3};
          int t3Target = 6;

          Console.WriteLine($"\n=====> Quais os indexes do array que somados resultam no valor alvo?");
          TwoSum(t1List,  t1Target);
          TwoSum(t2List,  t2Target);
          TwoSum(t3List,  t3Target);
        }

        static int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> mapedIntsIndex = new Dictionary<int, int>();
            int[] indexesToTarget = new int[] { -1, -1 };
            bool foundIndexes = false;

            int tempIndex = 0;

            while(!foundIndexes && tempIndex < nums.Length) {
              int currentNum = nums[tempIndex];
              int sumItemTarget = target - currentNum;

              // Searching if we can find the matching number index to sum to target
              if(mapedIntsIndex.ContainsKey(sumItemTarget)) {
                indexesToTarget[0] = mapedIntsIndex[sumItemTarget];
                indexesToTarget[1] = tempIndex;

                foundIndexes = true;
              }

              // Populating dictionary with nums and respective indexes
              mapedIntsIndex.TryAdd(nums[tempIndex], tempIndex);
              tempIndex++;
            }

            Console.WriteLine($"\nResultado para o array [ {string.Join(", ", nums)} ] e alvo {target}:");
            Console.WriteLine($" {indexesToTarget[0]} e {indexesToTarget[1]}  => {nums[indexesToTarget[0]]} + {nums[indexesToTarget[0]]} = {target}");

            return indexesToTarget;
        }
    }
}