using System;
using System.Collections.Generic;
using System.Text;

namespace OOPC_Workshop_Inheritance_PartI
{
    /// <summary>
    /// 新学到的事情：
    /// 只要在类里override ToString() 那就可以直接在.cw里打印相关信息
    /// </summary>
   public class Account
   {
        /**
         * TODO: create attributes
         * This class has 3 attributes:
         * acctNumber : string, private
         * acctHolderId : string, private
         * balance: double, private
         */
        private string acctNumber;
        private string acctHolderId;
        private double balance;


      public Account() { }

      /**
       * TODO: create constructor
       * This contructor receives 3 values
       * and initializes the 3 attributes accordingly
       */
      public Account(string acctNumber, string acctHolderId, double balance)
      {
            this.acctNumber = acctNumber;
            this.acctHolderId = acctHolderId;
            this.balance = balance;
      }

      /**
       * TODO: create properties
       * These properties expose the private attributes
       *
       * Note: acctNumber should be read-only, i.e. can not be
       * set from outside
       */
       public string AcctNumber
       {
            get { return this.acctNumber; }
       }

       public string AcctHolderId
        {
            get { return acctHolderId; }
            set { this.acctHolderId = value; }
        }
       public double Balance
        {
            get { return balance; }
            set { this.balance = value; }
        }

        /**
         * TODO: implement method Deposit
         * This method increases the account balance 
         * by the given amount
         */
        public void Deposit(double num)
        {
            this.balance += num;
        }



        /**
         * TODO: implement method Withdraw
         * This method decreases the account balance
         * by the given amount. Balance must NOT be negative.
         * It makes sure that there is enough balance to
         * widthdraw
         */
        public bool Withdraw(double num)
        {
            if (num < 0 || num > this.balance) return false;

            this.balance -= num;

            return true;
        }



        /**
         * TODO: implement method TransferTo
         * This method transfers a given amount to another given 
         * account. It makes sure that this sender has enough
         * balance before transfering
         */

        public bool TransferTo( Account to, double num)
        {
            if (this.balance < num) return false;

            this.balance -= num;
            to.Balance += num;

            return true;
        }


        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         */
        public override string ToString()
        {
            string info = "";
            info = "accountNumber = " + this.acctNumber + ", accoutHoler = " + this.AcctHolderId + ", balance = " + this.balance;
            return info;
        }



    }
}
