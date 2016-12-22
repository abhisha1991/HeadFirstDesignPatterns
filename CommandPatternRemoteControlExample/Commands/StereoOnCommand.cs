using CommandPatternRemoteControlExample.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternRemoteControlExample.Commands
{
    public class StereoOnCommand : ICommand
    {
        public Stereo StereoWithVolumeAndModes { get; set; }
        public StereoOnCommand(Stereo stereo)
        {
            StereoWithVolumeAndModes = stereo;
        }
        public void Execute()
        {
            Console.WriteLine("Setting high stereo volume!");
            StereoWithVolumeAndModes.StereoVol = Stereo.Volume.high;
            Console.WriteLine("Setting stereo on CD mode!");
            StereoWithVolumeAndModes.StereoMode = Stereo.Mode.cd;
            StereoWithVolumeAndModes.On();

        }
        public void Undo()
        {
            StereoWithVolumeAndModes.Off();
        }
    }
}
