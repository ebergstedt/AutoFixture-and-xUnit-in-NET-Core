using System;
using AutoFixture;
using AutoFixture_xUnit_Core.Containers;
using AutoFixture_xUnit_Core.SpecimenBuilders;
using Xunit;

namespace AutoFixture_xUnit_Core.Tests
{
    public class EmailDto_Test
    {
        [Fact]
        public void EmailMessageDto_Create_Message_Test()
        {
            // Arrange
            var fix = new Fixture();
            var message = fix.Create<EmailMessageDto>();

            // Assert
            Assert.True(!string.IsNullOrEmpty(message.Body));
            Assert.True(message.RecievedGMT > DateTime.MinValue);
        }

        [Fact]
        public void EmailMessageDto_Inject_Test()
        {
            // Arrange
            var fix = new Fixture();
            fix.Inject("TEST");

            var message = fix.Create<EmailMessageDto>();

            // Assert
            Assert.True(message.Body == "TEST");
        }

        [Fact]
        public void EmailMessageDto_Build_Test()
        {
            // Arrange
            var fix = new Fixture();
            var message = fix.Build<EmailMessageDto>()
                .Without(x => x.Body)
                .Do(x => x.Body = "BODY")
                .Without(x => x.From)
                .With(x => x.To, "TEST")
                .Create();

            // Assert
            Assert.True(message.Body == "BODY");
            Assert.True(string.IsNullOrEmpty(message.From));
            Assert.True(message.To == "TEST");
        }

        [Fact]
        public void EmailMessageDto_Specimen_Test()
        {
            // Arrange
            var fix = new Fixture();
            fix.Customizations.Add(new EmailMessageSpecimenBuilder());

            var message = fix.Create<EmailMessageDto>();

            // Assert
            Assert.True(message.Body == "BODY");
        }
    }
}
