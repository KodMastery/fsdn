using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.EventsDelegates
{
    internal class SmsService
    {
        internal void SendSmsOnVideoEncoded(string videoTitle)
        {
            Console.WriteLine($"Sending SMS to user after video encoding: {videoTitle}");
        }
    }
}
