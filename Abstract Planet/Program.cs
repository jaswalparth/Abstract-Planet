using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Parth Jaswal
 * Date: july 28,2017
 * Description: it is a driver program class
 * Version:0.1 
  */
namespace Abstract_Planet
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Mars", 6779, 6.39, "GAS");
            TerrestrialPlanets terrestrialPlanet = new TerrestrialPlanets("EARTH", 12742, 5.9722, true);
            giantPlanet.ToString();
            terrestrialPlanet.ToString();
            Program.WAITFORANYKEY();

        }
        static void WAITFORANYKEY()
        {
        }
    }
}
