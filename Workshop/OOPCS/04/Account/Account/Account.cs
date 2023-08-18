﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Workshop_Inheritance_PartII
{
   public class Account
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
        /// empty conscructor
        /// </summary>
        public Account(string acctNumber, string acctHolderId, double balance)
        {
            this.acctNumber = acctNumber;
            this.acctHolderId = acctHolderId;
            this.balance = balance;
        }
        public Account()
        {

        }

        public string AcctNumber
        {
            get { return acctNumber; }
        }
        public string AcctHolderId
        {
            get { return acctHolderId; }
            set { acctHolderId = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public bool Deposit(double num)
        {
            
            this.balance += num;
            return true;
        }

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
        /// deposit the interest to balance and return the balance.
        /// It will invoke the object generated by its child class.
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