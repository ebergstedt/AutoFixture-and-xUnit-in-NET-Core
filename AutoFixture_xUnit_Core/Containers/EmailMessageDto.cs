using System;
using System.Collections.Generic;
using System.Text;

namespace AutoFixture_xUnit_Core.Containers
{
    public class EmailMessageDto
    {
        public string From { get; set; }

        public string To { get; set; }

        public DateTime SentGMT { get; set; }

        public DateTime RecievedGMT { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }
    }
}
