using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Events
{
    internal class MailSevice
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("sending mail" + e.Video.Title);
        }
    }
}
