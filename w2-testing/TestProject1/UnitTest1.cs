using System;
using Xunit;
using TestDemo;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void IsValidMailAddress()
        {
            // Arrange
            string mail = "h.w.keuning@uu.nl";
            MailManager mailManager = new();

            // Act
            bool result = mailManager.IsValidAddress(mail);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("@uu.nl")]
        [InlineData("\\hoi@hoi.nl")]
        [InlineData("dit zijn spaties@x.nl")]

        public void IsUnvalidMailAddress(string mail)
        {
            // Arrange
            MailManager mailManager = new();

            // Act
            bool result = mailManager.IsValidAddress(mail);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void ValidDebitTransaction()
        {
            // Arrange
            BankAccount account = new("Hieke", 100);
            decimal amount = 25;

            // Act
            account.Debit(amount);

            // Assert
            Assert.Equal(75, account.Balance);

        }

        [Fact]
        public void InValidDebitTransaction()
        {
            // Arrange
            BankAccount account = new("Hieke", 100);
            decimal amount = 125;

            // Act
            Action action = () => account.Debit(amount);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(action);
            

        }
    }
}
