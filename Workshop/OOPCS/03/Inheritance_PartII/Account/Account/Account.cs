using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Workshop_Inheritance_PartII
{
   class Account
   {
        /**
         * TODO: copy whatver from part 1
         * You need to add and modify some attributes
         * and methods to support the derived 
         * classes
         */
        private string acctNumber;
        private string acctHolderId;
        private double balance;

        /// <summary>
        /// Account Conscructor
        /// </summary>
        public Account(string acctNumber, string acctHolderId, double balance)
        {
            this.acctNumber = acctNumber;
            this.acctHolderId = acctHolderId;
            this.balance = balance;
        }
        /// <summary>
        /// Empty Account Constructor
        /// </summary>
        public Account(){}

        /// <summary>
        /// Property of acctNumber
        /// </summary>
        public string AcctNumber
        {
            get { return acctNumber; }
        }
        /// <summary>
        /// Property of acctHolderId
        /// </summary>
        public string AcctHolderId
        {
            get { return acctHolderId; }
            set { acctHolderId = value; }
        }
        /// <summary>
        /// Property of balance
        /// </summary>
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        /// <summary>
        /// Common method Deposit()
        /// </summary>
        /// <param name="num">the value you wanna deposit</param>
        /// <returns></returns>
        public bool Deposit(double num)
        {
            
            this.balance += num;
            return true;
        }
        /// <summary>
        /// Use this function to deposit
        /// </summary>
        /// <param name="num">Enter the value you wanna deposit</param>
        /// <returns></returns>
        public virtual bool Withdraw(double num)
        {
            if (num < 0 || num > this.balance) return false;
            this.balance -= num;
            return true;
        }
        /// <summary>
        /// 转账代码
        /// </summary>
        /// <param name="to">目标账户的对象</param>
        /// <param name="num">转账金额</param>
        /// <returns></returns>
        public bool TransferTo(Account to, double num)
        {
            if (to == null || num > this.balance) return false;

            this.balance -= num;
            to.Balance += num;

            return true;
        }
        /// <summary>
        /// 可以直接在.cw里输出，系统会自动调用ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "AccountNum: " + this.acctNumber + ", AccountHolderId: " + this.AcctHolderId + ", Balance: " + this.balance;
        }
        /// <summary>
        /// calculate interest value
        /// </summary>
        /// <returns></returns>
        public virtual double CalculateInterest() { return 0;}
        /// <summary>
        /// deposit the interest to balance and return the balance
        /// </summary>
        /// <returns></returns>
        public virtual double CreditInterest()
        {
            var itr = CalculateInterest();
            Deposit(itr);
            return itr;
        }

    }
}