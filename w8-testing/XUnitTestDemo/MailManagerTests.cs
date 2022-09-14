using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo;
using Xunit;

namespace XUnitTestDemo
{
    public class MailManagerTests
    {

        [Fact]
        public void ValidMail()
        {
            // Arrange
            MailManager mailManager = new();
            const string mailAddress = "h.w.keuning@uu.nl";

            // Act
            bool isValid = mailManager.IsValidAddress(mailAddress);

            // Assert
            Assert.True(isValid, $"The email {mailAddress} is not valid");
        }

        [Theory]
        [InlineData("john.smith@company.com", true)]
        [InlineData("johnsmith@company.com", true)]
        [InlineData("john.smith@company.comma", true)]
        [InlineData("john.smith@company.it", true)]
        [InlineData("john.smith.company.com", false)]
        [InlineData("john@smith@company.com", false)]
        [InlineData("john", false)]
        [InlineData("", false)]
        public void CheckMail(string email, bool isValid)
        {
            // Arrange
            MailManager mailManager = new();

            // Act
            bool actual = mailManager.IsValidAddress(email);

            //Assert
            Assert.Equal(isValid, actual);
        }

    }
}
