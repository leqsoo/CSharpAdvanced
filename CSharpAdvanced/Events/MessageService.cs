using CSharpAdvanced.Events;

namespace CSharpAdvanced
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("sending message" + e.Video.Title);
        }
    }
}