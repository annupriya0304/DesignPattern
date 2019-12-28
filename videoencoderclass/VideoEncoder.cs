using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace videoencoderclass
{
    class VideoEncoder
    {

        //define a delegegate
        //attach an event
        //raise an event

        public delegate void VideoEncodeEvenetHandler(object source, EventArgs args);

        public event VideoEncodeEvenetHandler VideoEncoded;


        public void Encode(video video)
        {

            Console.WriteLine("Encoding..");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            //if there are no subscriber
            if(VideoEncoded !=null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }

}
