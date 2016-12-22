using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePatternHomeTheaterExample.HomeTheaterComponents;

namespace FacadePatternHomeTheaterExample
{
    public class HomeTheaterFacade
    {
        public Amplifier AmpObj { get; set; }
        public DvdPlayer DvdPlayerObj { get; set; }
        public PopcornPopper PopcornPopperObj { get; set; }
        public Screen ScreenObj { get; set; }
        public TheaterLights TheaterLightsObj { get; set; }
        public Projector ProjectorObj { get; set; }

        public HomeTheaterFacade(Amplifier a, DvdPlayer d, PopcornPopper p, Screen s, TheaterLights t, Projector pr)
        {
            AmpObj = a;
            DvdPlayerObj = d;
            PopcornPopperObj = p;
            ScreenObj = s;
            TheaterLightsObj = t;
            ProjectorObj = pr;
        }

        public void WatchMovie(string Movie)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Starting to get ready to watch the movie: " + Movie);
            Console.ForegroundColor = ConsoleColor.White;
            PopcornPopperObj.On();
            PopcornPopperObj.Pop();
            TheaterLightsObj.Dim();
            ScreenObj.Down();
            ProjectorObj.On();
            ProjectorObj.WidescreenMode();
            AmpObj.On();
            AmpObj.SetDVD(Movie);
            AmpObj.SetSurroundSound();
            AmpObj.SetVolume(10);
            DvdPlayerObj.On();
            DvdPlayerObj.Play(Movie);


        }

        public void EndMovie()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Shutting down the movie!");
            Console.ForegroundColor = ConsoleColor.White;
            PopcornPopperObj.Off();
            TheaterLightsObj.On();
            ScreenObj.Up();
            ProjectorObj.Off();
            AmpObj.Off();
            DvdPlayerObj.Pause();
            DvdPlayerObj.Eject();
            DvdPlayerObj.Off();

        }
        
    }
}
