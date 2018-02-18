using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFixture_xUnit_Core.Containers
{
    public class EmailInboxDto
    {
        public EmailInboxDto()
        {
            Emails = new List<EmailMessageDto>();
        }

        public List<EmailMessageDto> Emails { get; set; }

        public string Owner { get; set; }
    }
}
