using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPC_Workshop_Inheritance_PartI
{
   class Test1
   {
      public static void Main()
      {
            // Test class Account by creating an Account object
            // and call methods to make sure your code at 
            // class Account work
          
         // TODO. Create object
         // 1. Create a new Account object account1
         // - accNumber: S0000111
         // - acctHolderId: S1111111A
         // - balance: 2000
         // 2. Call Console.WriteLine(account1)
         // Make sure that the account information 
         // is displayed correctly
         
            Account account1 = new Account("S0000111", "S1111111A",2000);
            Console.WriteLine(account1);
            Account account2 = new Account();


            // TODO: Deposit
            // Deposit 200 to the acccount.
            // Display the account information again and 
            // manually verify the new balance
            account1.Deposit(200);
            Console.WriteLine(account1);


            // TODO: Widthdraw
            // Withdraw 200 from the account.
            // Display the account information again and
            // manually verify the new balance
            account1.Withdraw(200);
            Console.WriteLine(account1);


            // TODO: Widthdraw
            // Withdraw 4000 from the account.
            // Make sure that the withdrawing is unsuccessful.
            if (account1.Withdraw(4000))
            {
                Console.WriteLine(account1); 
            }
            else
            {
                Console.WriteLine("Failed");
            }


            Console.ReadKey();
      }

   }
}
