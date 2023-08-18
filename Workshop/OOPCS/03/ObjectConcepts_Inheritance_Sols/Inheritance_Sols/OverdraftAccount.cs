using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Workshop_Inheritance_Sols
{
   /**
    * This class should derive from class Account.
    * Current Account earns 0.25% interest for postive 
    * balance. Balance can be negative, but it is required 
    * to pay 6% interest for negative balance.
    */
   public class OverdraftAccount : Account
   {
      // Attributes
      private static double interestRate = 0.25;
      private static double overdraftInterest = 6;

      // Constructors
      public OverdraftAccount(string number, string holderId, double bal)
          : base(number, holderId, bal) {}

      // Methods

      // For Widthraw(), the implementation is the same as parent's
      // so, we don't need to override

      // This method overrides its parent's and
      // provides its own implementation
      public override double CalculateInterest()
      {
         if (Balance > 0)
            return Balance * interestRate / 100;

         else
            return Balance * overdraftInterest / 100;
      }

      public override string ToString()
      {
         return string.Format("(OverdraftAccount){0}",
             base.ToString());
      }
   }
}
