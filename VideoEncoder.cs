using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegateTest
{
    public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
    public class VideoEncoder
    {

        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        public event VideoEncodedEventHandler VideoEncoded; // Methods can be attached to this Event.

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(1500);
            PublisherOnVideoEncoded(video);
        }

        protected virtual void PublisherOnVideoEncoded(Video video) // Publisher Method
        {
            if (VideoEncoded != null) // Check if VideoEncoded Events have methods attached to it.
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
                // If VideoEncoded Event have Methods attached to it,
                // then make the VideoEncoded Event call the methods attached to it,
                // with the following input --> Video = video
            }
        }
    }
    public class mailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) // Method with Delegate Signature
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) // Method with Delegate Signature
        {
            Console.WriteLine("MessageService: Sending an message..." + e.Video.Title);
        }
    }

}


