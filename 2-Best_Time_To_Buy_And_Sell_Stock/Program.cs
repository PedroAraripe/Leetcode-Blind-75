using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine($"\n=====> Qual a maior taxa de lucro possível para esse histórico de valores de uma ação?");

          int[] t1List = {7,1,5,3,6,4};
          int t1Result = MaxProfit(t1List);
          Console.WriteLine($"{t1Result}");
          
          int[] t2List = {7,6,4,3,1};
          int t2Result = MaxProfit(t2List);
          Console.WriteLine($"{t2Result}");
        }
        
        static int MaxProfit(int[] prices) {
            int bestStart = prices[0];
            int bestDeal = 0;

            for(int i=1; i<prices.Length; i++) {
                int currentPrice = prices[i];
                int currentDeal = currentPrice - bestStart;

                if(currentDeal > bestDeal) {
                    bestDeal = currentDeal; 
                }

                if(currentPrice < bestStart) {
                    bestStart = currentPrice; 
                }
            }

            return bestDeal;
        }
    }

}