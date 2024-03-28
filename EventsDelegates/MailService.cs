using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.EventsDelegates
{
    internal class MailService
    {
        internal void SendEmailOnVideoEncoded(string title)
        {
            Console.WriteLine($"Sending email to user after encoded video {title}");
        }
    }
}
