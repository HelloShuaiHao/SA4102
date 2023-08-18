using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Workshop_Inheritance_Sols
{
   /**
    * This class should derive from class Account.
    * Savings Account earns 1% interest, but balance can not be negative
    */
   public class SavingsAccount : Account
   {
      // Attributes
      private static double interestRate = 1;

      // Constructors
      public SavingsAccount(string number, string holder, double bal)
          : base(number, holder, bal) { }

      // Methods

      // This method overrides its parent's and
      // provides its own implementation
      public override double CalculateInterest()
      {
         return Balance * interestRate / 100;
      }

      // This method overrides its parent's and
      // provides its own implementation
      public override bool Withdraw(double amount)
      {
         if (amount < Balance) {
            // Ok to widthraw, logic is like the parent's
            // So let's reuse the parent's
            return base.Withdraw(amount);
         }
         else
         {
            return false;
         }
      }

      public override string ToString()
      {
         return string.Format("(SavingsAccount){0}",
             base.ToString());
      }
   }
}
