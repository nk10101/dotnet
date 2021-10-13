using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConceptArchitect.Finance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptArchitect.Finance.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        BankAccount obj1 = new BankAccount(1, "Ae", "PASS", 6000, 2);

         [TestMethod()]
        public void DepositTest()
        {
            var actual = obj1.Deposit(2000);
            int expected = 8000;

            Assert.AreEqual(expected,obj1.Balance);
        }

        [TestMethod()]
        public void WithdrawTestCorrectPassword()
        {

            var actual = obj1.Withdraw(4000,"PASS");

            int expected = 2000;

            Assert.AreEqual(expected, obj1.Balance);
        }


        [TestMethod()]
        public void WithdrawTestWrongPassword()
        {

            var actual = obj1.Withdraw(4000, "PASS11");

            bool expected = false;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CreditInterestTest()
        {

             int expected = 6000+(6000 * 2 / 1200);
            obj1.CreditInterest();
            Assert.AreEqual(expected, obj1.Balance);
           
        }

     
    }
}