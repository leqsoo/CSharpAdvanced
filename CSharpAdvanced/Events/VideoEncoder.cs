namespace CSharpAdvanced.Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    internal class VideoEncoder
    {

        //Creating Event
        //1-Define a Delegate
        //public delegate void VideoEncoderEventHandler(object sender, VideoEventArgs e);

        //2 - Define an Event based on That Delegate
        //public event VideoEncoderEventHandler VideoEncoded;

        //Without Defining a Delegate
        public event EventHandler<VideoEventArgs> VideoEncoded;

        //3 Rise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }

        public void Encode(Video video)
        {
            Console.WriteLine("video encoding");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
    }
}
