using System;
using System.Collections.Generic;
using System.Text;

namespace OOPC_Workshop_Inheritance_PartI
{

   public class Account
   {
      /**
       * TODO: create attributes
       * This class has 3 attributes:
       * acctNumber : string, private
       * acctHolderId : string, private
       * balance: double, private
       */

      public Account() { }

      /**
       * TODO: create constructor
       * This contructor receives 3 values
       * and initializes the 3 attributes accordingly
       */
      public Account(string acctNumber, string acctHolderId, double balance)
      {
         
      }

      /**
       * TODO: create properties
       * These properties expose the private attributes
       *
       * Note: acctNumber should be read-only, i.e. can not be
       * set from outside
       */




      /**
       * TODO: implement method Deposit
       * This method increases the account balance 
       * by the given amount
       */




      /**
       * TODO: implement method Withdraw
       * This method decreases the account balance
       * by the given amount. Balance must NOT be negative.
       * It makes sure that there is enough balance to
       * widthdraw
       */




      /**
       * TODO: implement method TransferTo
       * This method transfers a given amount to another given 
       * account. It makes sure that this sender has enough
       * balance before transfering
       */




      /**
       * TODO: override method ToString
       * This method returns the values of the attributes
       * of the current object in a more readable format
       * For example: 
       * Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
       */




   }
}
