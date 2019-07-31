using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a customer's bank account
    /// </summary>
    public class Account
    {
        private string _accountNumber;

        // name of account holder
        // account number
        // balance

        // changed to fully implemented property to account for null value as account#
        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                // this can be simplified, but not needed right now ( ?? ) 
                if ( value == null )
                {
                    throw new ArgumentNullException($"{nameof(AccountNumber)} cannot be null");
                }
                // account for special characters
                if (value.Contains("#"))
                {
                    throw new ArgumentException($"{nameof(AccountNumber)} cannot contain # signs");
                }
                _accountNumber = value;
            }
        }





        public string Owner { get; set; }

        // set as private for encapsulation purposes
        public double Balance { get; private set; }


        /// <summary>
        /// Adds an amount to the current balance and returns the updated balance
        /// </summary>
        /// <param name="amount">The amount to add</param>
        /// <returns>The new balance</returns>
        public double Deposit(double amount)
        {
            if (amount < 0)
            {
                // throw exception for fellow developer, nameof() for refactoring support
                throw new ArgumentException($"{nameof(amount)} cannot be negative");
            }

            // can't change behavior here due to risk 
            //amount = Math.Truncate(100 * amount) / 100;

            Balance += amount;
            return Balance;
        }



        /// <summary>
        /// Subtracts given amount from current balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }





    }
}
