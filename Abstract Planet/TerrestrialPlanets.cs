using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Parth Jaswal
 * Date: july 28,2017
 * Description: TerrestrialPlanet class which inherts from Planet class
 * Version:0.1 created GiantPlanet class
  */
namespace Abstract_Planet
{
    /// <summary>
    /// Terristial planet class
    /// </summary>
    public class TerrestrialPlanets : Planet, IHasMoon, IHabital
    {
        //private instance variable
        private bool _oxygen;

        //public properties

        /// <summary>
        /// constructor for the terristial planet class
        /// take four argument - name(string) , diameter(double) , mass(double) , oxygen(bool)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        // CONSTRUCTOR--------------

        public TerrestrialPlanets(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
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

        public bool Habitable()
        {
            if (_oxygen == true)
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
