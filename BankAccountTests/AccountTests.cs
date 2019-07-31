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

        [TestMethod]
        [DataRow(99)]
        [DataRow(10000)]
        [DataRow(10.995)]
        [TestCategory("Deposit")]
        public void Deposit_SinglePositiveAmounts_AddsToBalance(double amt)
        {
            // arrange
            Account checking = new Account();
            double expectedBalance = amt;

            // act - calling the method under test
            checking.Deposit(amt);

            // assert
            Assert.AreEqual(expectedBalance, checking.Balance);

        }


        [TestMethod()]
        [TestCategory("Deposit")]
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
        [TestCategory("Deposit")]
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
        [TestCategory("Deposit")]
        public void Deposit_NegativeAmount_ThrowsArgumentException()
        {
            // arrange
            Account acc = new Account();
            double depositAmt = -1;

            // act => assert: in this case - really assert then act
            // using anonymous function, this should throw the exception 
            Assert.ThrowsException<ArgumentException>( () => acc.Deposit(depositAmt) );
        }




        [TestInitialize] // runs this method before every test
        public void InitTest()
        {
            // arrange
            acc = new Account();
            acc.Owner = "Some person";
            acc.AccountNumber = "ABC123";
            
        }
        // field for testInitializer featured above
        Account acc;




        [TestMethod]
        public void Withdraw_PositiveAmount_ReducesBalance()
        {
            // arrange
            double initialDeposit = 100;
            double withdrawAmount = 10;
            double expectedAmount = 90;

            // act
            acc.Deposit(initialDeposit);
            acc.Withdraw(withdrawAmount);

            // assert
            Assert.AreEqual(expectedAmount, acc.Balance);

        }



        [TestMethod]
        [DataRow("123456")]
        [DataRow("abc123")]
        [DataRow("A")]
        [DataRow("101010101")]
        public void AccountNum_SetValidAcc_UpdateAccNum( string validAcc)
        {
            // arrange is already set up
            // act
            acc.AccountNumber = validAcc;

            // assert
            Assert.AreEqual(validAcc, acc.AccountNumber);
        }



        [TestMethod]
        [DataRow("abc#")]
        [DataRow("#abc")]
        [DataRow("asdf#asdf")]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void AccountNum_SetInvalidAccountNumber_ThrowsException( string invalidAccountNumbers)
        {
            // arrange is already set up

            // assert and act together

            //TODO: split this into multiple tests with specific exceptions
            Assert.ThrowsException<Exception>(() => acc.AccountNumber = invalidAccountNumbers);


        }


    }
}