using System;
using Xunit;
using TestDemo;
using Xunit.Extensions;

namespace XUnitTestDemo
{
    public class BankAccountTests
    {
       
        [Fact]
        public void DebitWithValidAmount()
        {
            //arrange
            decimal beginningBalance = 11.99m;
            decimal debitAmount = 4.55m;
            decimal expected = 7.44m;
            BankAccount account = new ("Mr. Walter White" , beginningBalance);

            // act
            account.Debit(debitAmount);

            // assert
            decimal actual = account.Balance;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DebitTriggerException()
        {
            // arrange
            decimal beginningBalance = 11.99m;
            decimal debitAmount = 20.0m;
            BankAccount account = new ("Mr. Walter White", beginningBalance);

            // Act 
            Action debitAction = () => account.Debit(debitAmount);

            // Assert
            var exc = Assert.Throws<ArgumentOutOfRangeException>(debitAction);
            Assert.Contains("amount", exc.Message); // liever geen 2x assert, een AmountException o.i.d. was beter geweest
        }


    }
}
