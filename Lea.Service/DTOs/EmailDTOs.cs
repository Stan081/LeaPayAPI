using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lea.Service.DTOs
{
    internal class SendBulkEmailDto
    {
        public required string Sender { get; set; }
        public required List<string> To { get; set; }
        public required string Body { get; set; }
    }

    public class SendEmailDto {
        public required string Sender { get; set; }
        public required string To { get; set; }
        public required string Body { get; set; }
    }
}
