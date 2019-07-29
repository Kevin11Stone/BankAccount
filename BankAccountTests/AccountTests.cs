using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {

        [TestMethod()]
        public void DepositTest_PositiveAmount_AddsToBalance()
        {
            // AAA: Arrange, Act, Assert

            // arrange - Init objects/variables
            Account checking = new Account();
            double depositAmt = 10;
            double expectedBalance = 10;

            // act - call method under test
            checking.Deposit(depositAmt);

            // assert - verify action
            Assert.AreEqual(expectedBalance, checking.Balance);
        }


        [TestMethod]
        public void Deposit_PositiveAmount_ReturnsUpdatedBalance()
        {
            // arrange
            Account acc = new Account();
            double depositAmt = 10.55;
            double expectedReturn = 10.55;

            // act
            double result = acc.Deposit(depositAmt);

            // assert
            Assert.AreEqual(expectedReturn, result);
        }


        [TestMethod]
        public void Deposit_NegativeAmount_ThrowsArgumentException()
        {
            // arrange
            Account acc = new Account();
            double depositAmt = -1;

            // act => assert: in this case - really assert then act
            // using anonymous function, this should throw the exception 
            Assert.ThrowsException<ArgumentException>( () => acc.Deposit(depositAmt) );


        }


    }
}