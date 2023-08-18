using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Workshop_Inheritance_PartII
{
   /**
    * This class should derive from class Account.
    * Current Account earns 0.25% interest, but balance can not be negative
    */
   class CurrentAccount : Account
   {
        /**
         * TODO: attributes
         * Add instance or static attribute when neccessary
         */
        private static double interest = 0.0025;


      /**
       * TODO: create a constructor that accepts 3
       * parametes. The constructor should make use
       * of its parent's constructor to initialize
       * its attributes
       */
        public CurrentAccount() { }
        public CurrentAccount(string acctNumber, string acctHolderId, double num) : base(acctNumber, acctHolderId, num)
        {

        }



        /**
         * TODO: implement method CalculateInterest
         * The method return the interest of this account.
         * Current Account earns 0.25% interest of its balance.
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */
        public override double CalculateInterest()
        {
            return interest * this.Balance;
        }



        /**
         * TODO: implement method CreditInterest
         * The method deposit the interst amount, returns by
         * CalculateInterest() method of this
         * account to its balance.
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */

        /*
        public override double CreditInterest()
        {
            double itr = this.CalculateInterest();
            this.Balance += itr;
            return this.Balance;
        }*/



        /**
         * TODO: override method Widthraw
         * This method decreases the account balance
         * by the given amount. 
         * For a Current Accounts, balance cannot be negative
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */





        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * (CurrentAccount) Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         * 
         * This method should make use of its parent's method
         */




    }
}
