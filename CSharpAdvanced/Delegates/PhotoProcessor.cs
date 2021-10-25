using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    internal class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = new Photo();
            filterHandler(photo);
            photo.Save();
        }
    }
}
