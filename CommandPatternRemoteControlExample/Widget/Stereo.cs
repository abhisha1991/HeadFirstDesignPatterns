using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Widget
{
    public class Stereo
    {
        public Volume StereoVol { get; set; }
        public Mode StereoMode { get; set; }
        public enum Volume
        {
            off = 0,
            low = 1,
            medium = 2,
            high = 3 
        }

        public enum Mode
        {
            none =0,
            cd =1,
            radio =2,
            dvd =3
        }

        public Stereo()
        {
            StereoVol = Volume.off;
            StereoMode = Mode.none;
        }
        public void On()
        {
            if(StereoVol == Volume.off)
            {
                StereoVol = Volume.medium;
            }
            if(StereoMode == Mode.none)
            {
                StereoMode = Mode.radio;
            }
            Console.WriteLine("Stereo is on with Volume: " + StereoVol + " and Mode: " + StereoMode);
        }

        public void Off()
        {
            if(StereoVol  == Volume.off)
            {
                Console.WriteLine("Stereo is already off");
                return;
            }
            else
            {
                StereoVol = Volume.off;
                StereoMode = Mode.none;
                Console.WriteLine("Stereo has been turned off!");

            }
        }

        
    }
}
