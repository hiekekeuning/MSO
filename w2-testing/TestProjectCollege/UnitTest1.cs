using System;
using Xunit;
using TestDemo;

namespace TestProjectCollege
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            BankAccount b1 = new BankAccount("Hieke", 100);

            //Act 
            b1.Credit(20);

            //Assert
            Assert.Equal(120, b1.Balance);
        }

        [Fact]
        public void TestMail()
        {
            string ad = "h.w.keuning@uu.nl";
            MailManager mm = new();

            bool res = mm.IsValidAddress(ad);

            Assert.True(res);
        }

        [Theory]
        [InlineData("")]
        [InlineData("sdjkfh")]
        public void InvalidEmails(string a)
        {
            MailManager mm = new();

            bool res = mm.IsValidAddress(a);

            Assert.False(res);

        }

        [Fact]
        public void T()
        {
            var b = new BankAccount("", 99);

            b.Credit(4);

            Assert.Equal(95, b.Balance);
        }
    }
}
