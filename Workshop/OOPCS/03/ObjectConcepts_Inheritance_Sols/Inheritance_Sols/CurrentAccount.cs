using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Workshop_Inheritance_Sols
{
   /**
    * This class should derive from class Account.
    * Current Account earns 0.25% interest, but balance can not be negative
    */
   public class CurrentAccount : Account
   {
      // Attributes
      private static double interestRate = 0.25;

      // Constructors
      public CurrentAccount(string number, string holderId, double bal)
          : base(number, holderId, bal)
      {
      }

      public override double CalculateInterest()
      {
         return Balance * interestRate / 100;
      }

      // This method overrides its parent's and
      // provides its own implementation
      public override bool Withdraw(double amount)
      {
         if (amount < Balance)
         {
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
         return string.Format("(CurrentAccount){0}",
             base.ToString());
      }


   }
}
