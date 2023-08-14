using System;

namespace TaxCalculator
{
    class program
    {
        static int[] minIncomeArray = new int[]
        {
            20000,30000,40000,80000,120000,160000,200000,320000
        };

        static double[] taxRateArray = new double[]
        {
            0.02,0.035,0.07,0.115,0.15,0.17,0.18,0.20
        };
        static int[] basePayableAmountArray = new int[]
        {
            0,200,550,3350,7950,13950,20750,42350
        };

        static void Main()
        {
            int annualIncome = AskForIncome();

            int taxBracket = GetTaxBracket(annualIncome);

            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);

            PrintResult(annualIncome, taxPayable);
        }

        public static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income");
            int income = Convert.ToInt32(Console.ReadLine());
            return income;
        }

        public static int GetTaxBracket(int income)
        {
            int index = -1;
            int i = 0;
            while(i<minIncomeArray.Length && income >= minIncomeArray[i])
            {
                index = i;
                i++;
            }
            return index;
        }

        public static double CalculateIncomeTax(int income, int index)
        {
            double ans = 0;
            if (index == -1) return ans;

            ans = basePayableAmountArray[index] + (income - minIncomeArray[index]) * taxRateArray[index];
            return ans;
        }

        public static void PrintResult(int income, double tax)
        {
            Console.WriteLine($"For taxable annual income of ${income:#,##0.00}, the tax payable amount is ${tax:#,##0.00}");
        }
    }
}