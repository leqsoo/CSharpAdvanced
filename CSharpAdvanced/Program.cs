using CSharpAdvanced.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvanced
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var processor = new PhotoProcessor();
            //var filters = new PhotoFilters();
            //Action<Photo> filterhandler = filters.ApplyBrighness;
            //filterhandler += filters.ResizePhoto;
            //filterhandler += RemoveRedEyeFilter;
            //processor.Process("jk.jk", filterhandler);

            Video video = new Video { Title = "Video1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailSevice(); //Subscriber
            var messageService = new MessageService(); //Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("red");
        }
    }
}

