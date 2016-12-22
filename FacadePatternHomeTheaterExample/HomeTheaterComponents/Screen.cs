using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHomeTheaterExample.HomeTheaterComponents
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Getting the screen up");
        }

        public void Down()
        {
            Console.WriteLine("Getting the screen down");
        }
    }
}
