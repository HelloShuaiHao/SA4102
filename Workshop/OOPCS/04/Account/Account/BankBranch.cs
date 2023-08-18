using System;
namespace OOPCS_Workshop_Inheritance_PartII
{
	public class BankBranch
	{

		private string name;
		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		/// <summary>
		/// A list to store the account information.
		/// </summary>
		private List<Account> accounts = new List<Account>();

		/// <summary>
		/// Empty constructor
		/// </summary>
		public BankBranch()
		{
		}
        /// <summary>
        /// BankBranch Constructor
        /// </summary>
        /// <param name="name">BankBranch Name</param>
        public BankBranch(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// Add a new account info to the bankbranch
		/// </summary>
		/// <param name="newAccount"></param>
		/// <returns></returns>
		public bool AddAccount(Account newAccount)
		{
			if (newAccount == null || IfContainsAccount(newAccount)) return false;
			accounts.Add(newAccount);
			return true;
		}

		/// <summary>
		/// Avoid duplication of bank account
		/// </summary>
		/// <param name="check">The account you wanna check</param>
		/// <returns></returns>
		public bool IfContainsAccount(Account check)
		{
			foreach(Account temp in accounts)
			{
				if (temp.AcctNumber == check.AcctNumber) return true;
			}
			return false;
		}

		/// <summary>
		/// Print all the holder's id in this bankbranch.
		/// </summary>
		public void PrintCustomers()
		{
			foreach(var item in accounts)
			{
				Console.WriteLine("Holder ID: " + item.AcctHolderId);
			}
			return;
		}

		/// <summary>
		/// Calculate the total deposit of this bankbranch
		/// </summary>
		/// <returns>The total deposit</returns>
		public double TotalDeposit()
		{
			double sum = 0;
			foreach (var item in accounts) sum += item.Balance;
			return sum;
		}

		/// <summary>
		/// Calculate the totla interest
		/// </summary>
		/// <returns>The total interest</returns>
		public double TotalInterestPaid()
		{
			double sum=0;
			foreach (var item in accounts)
			{
				if (item.CalculateInterest() > 0) sum += item.CalculateInterest();
			}
			return sum;
		}

        /// <summary>
        /// Calculate the totla earned interest
        /// </summary>
        /// <returns>The total earned interest</returns>
        public double TotalInterestEarned()
        {
            double sum = 0;
            foreach (var item in accounts)
            {
                sum -= item.CalculateInterest();
            }
            return sum;
        }

		/// <summary>
		/// Print out all the accounts.
		/// </summary>
		public void PrintAccounts()
		{
			foreach (var item in accounts)
				Console.WriteLine(item);
		}


    }
}

