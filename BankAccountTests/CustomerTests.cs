using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Create_ValidCustomer_SetsName()
        {
            string firstname = "J";
            string lastName = "Doe";
            Customer c = new Customer(firstname, lastName);

            string fullName = c.FullName;

            Assert.AreEqual(fullName, c.FullName);

        }



    }
}
