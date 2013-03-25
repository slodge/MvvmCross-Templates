using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyApplication.Core.Messages
{
    public class ErrorMessage : Message
    {
        public string Message { get; private set; }

        public ErrorMessage(object sender, string message) : base(sender)
        {
            Message = message;
        }
    }
}
