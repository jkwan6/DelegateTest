using System;

namespace DelegateTest
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("MessageService: Sending a test message..." + e.Video.Title);
        }
    }
}
