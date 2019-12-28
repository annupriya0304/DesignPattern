using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoencoderclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new video() { Title= "v1"};
            var videoencode = new VideoEncoder();// publisher
            var mailservice = new MailService();// subscriber

           videoencode.VideoEncoded += mailservice.OnVideoEncode;

            videoencode.Encode(video);
            var list = new List<string>();


            Console.ReadKey();
        }
    }

    public class MailService
    {
        public void OnVideoEncode(object obj, EventArgs e)
        {
            Console.WriteLine("sent mail");
        }
    }
}
