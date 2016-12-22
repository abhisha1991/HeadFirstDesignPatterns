using CommandPatternRemoteControlExample.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Commands
{
    public class StereoOffCommand : ICommand
    {
        public Stereo StereoWithVolumeAndModes { get; set; }
        public StereoOffCommand(Stereo stereo)
        {
            StereoWithVolumeAndModes = stereo;
        }
        public void Execute()
        {
            StereoWithVolumeAndModes.Off();
            StereoWithVolumeAndModes.Off(); //Attempt to turn it off again!
        }

        public void Undo()
        {
            StereoWithVolumeAndModes.On();
        }
    }
}
