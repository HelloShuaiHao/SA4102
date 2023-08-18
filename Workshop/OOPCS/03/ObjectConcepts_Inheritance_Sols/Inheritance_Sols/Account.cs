

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Workshop_Inheritance_Sols
{
   public class Account
   {
      // Attributes
      private string acctNumber;
      private string acctHolderId;
      private double balance;

      // Constructors
      public Account(string number, string holder, double bal)
      {
         acctNumber = number;
         acctHolderId = holder;
         balance = bal;
      }

      // Properties
      public string AccountNumber
      {
         get
         {
            return acctNumber;
         }
      }
      public string AccountHolderId
      {
         get
         {
            return acctHolderId;
         }
         set
         {
            acctHolderId = value;
         }
      }
      public double Balance
      {
         get
         {
            return balance;
         }
         set
         {
            balance = value;
         }
      }

      // Methods
      public void Deposit(double amount)
      {
         Balance += amount;
      }

      public virtual bool Withdraw(double amount)
      {
         // This method will be overriden, 
         // Just select an implementation, for example
         // here we don't need to check the Balance
         Balance -= amount;
         return true;
      }

      public bool TransferTo(double amount, Account another)
      {
         bool isWithdrawOk = Withdraw(amount);

         if (isWithdrawOk)
         {
            another.Deposit(amount);
            return true;
         }
         else
         {
            return false;
         }
      }

      public virtual double CalculateInterest()
      {
         // This method will be overriden, just return something
         return 0;
      }

      // In all type of Accounts (SavingsAccount, CurrentAccount, 
      // OverdraftAccount), this method has the SAME implementation
      // So just put it in this parent class and derived classes
      // don't need to override
      public void CreditInterest()
      {
         var interest = CalculateInterest();

         Deposit(interest);
      }

      public override string ToString()
      {
         string m = string.Format
               ("Account : accountNumber={0}, accountHolder={1}, balance={2}",
                        AccountNumber, AccountHolderId, Balance);
         return m;
      }
   }
}
