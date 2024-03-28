using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.EventsDelegates
{
    internal class Video
    {
        internal string Title { get; set; }
        internal string Description { get; set; }
        internal int Length { get; set; }

        public Video(string title, string description, int length)
        {
            Title  = title;
            Description = description;
            Length = length;
        }
    }
}
