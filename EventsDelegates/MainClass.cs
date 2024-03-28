namespace FSDN.EventsDelegates
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Video video = new Video("James Bond", "James bond kills everyone", 120);
            
            VideoEncodingService videoEncodingService = new VideoEncodingService();
            
            SmsService smsService = new SmsService();
            MailService mailService = new MailService();
            ViberService viberService = new ViberService();

            videoEncodingService.NotifyOnVideoEncoded += smsService.SendSmsOnVideoEncoded;
            videoEncodingService.NotifyOnVideoEncoded += mailService.SendEmailOnVideoEncoded;
            videoEncodingService.NotifyOnVideoEncoded += viberService.SendViberMessageOnVideo;


            videoEncodingService.EncodeVideo(video);
            videoEncodingService.NotifyOnVideoEncoded -= smsService.SendSmsOnVideoEncoded;

        }

    }
}