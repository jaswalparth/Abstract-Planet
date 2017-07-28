using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Parth Jaswal
 * Date: july 28,2017
 * Description: GiantPlanet class which inherts from Planet class
 * Version: 0.1 created GiantPlanet class
 */
namespace Abstract_Planet
{
    /// <summary>
    /// GiantPlanet class
    /// </summary>
    public class GiantPlanet : Planet, IHasMoon, IHasRings
    {
        //private instance variable
        private string _type;

        //public properties

        //CONSTRUCTOR--------
        /// <summary>
        /// constructor for GiantPlanet
        /// takes three argument - name(string) -diameter(double) - mass(double) 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        

        public GiantPlanet(string name, double diameter, double mass, string type) : base (name, diameter, mass)
        {
            this._type = type;
        }

        public bool HasMoon()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

