using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoFixture;
using AutoFixture_xUnit_Core.Containers;
using Xunit;

namespace AutoFixture_xUnit_Core.Test
{
    public class EmailInboxDto_Test
    {
        [Fact]
        public void EmailInboxDto_Create_Inbox_Test()
        {
            // Arrange
            var fix = new Fixture();
            var inbox = fix.Create<EmailInboxDto>();

            // Assert
            Assert.True(inbox.Emails.Count > 0);
        }

        [Fact]
        public void EmailInboxDto_Inject_Inbox_Test()
        {
            // Arrange
            var fix = new Fixture();

            var messageDto = fix.Create<EmailMessageDto>();

            fix.Inject(messageDto);

            var inbox1 = fix.Create<EmailInboxDto>();
            var inbox2 = fix.Create<EmailInboxDto>();

            // Assert
            Assert.True(inbox1.Emails.First().Body == messageDto.Body);
            Assert.True(inbox2.Emails.First().Body == messageDto.Body);
        }
    }
}
