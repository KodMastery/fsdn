using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDN.EventsDelegates
{
    internal class VideoEncodingService
    {
        internal delegate void NotifyVideoEncodedHandler(string title);

        internal event NotifyVideoEncodedHandler NotifyOnVideoEncoded;
        internal void EncodeVideo(Video videoToBeEncoded)
        {
            Console.WriteLine($"Encoding video... {videoToBeEncoded.Title}");
            OnVideoEncoded(videoToBeEncoded);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            NotifyOnVideoEncoded?.Invoke(video.Title);
        }
    }
}
