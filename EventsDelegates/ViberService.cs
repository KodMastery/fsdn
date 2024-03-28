using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.EventsDelegates
{
    internal class ViberService
    {
        internal void SendViberMessageOnVideo(string name)
        {
            Console.WriteLine($"Sending viber message on video {name}");
        }
    }
}
