using System;

namespace DelegateTest
{

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" }; // New Video Instance with Property Title = Video 1
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new mailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            System.Console.ReadLine();
        }
    }
    public class Video
    {
        public string Title { get; set; }
    }
}
