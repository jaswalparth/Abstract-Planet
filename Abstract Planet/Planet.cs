using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 *Name: Parth Jaswal
 *Date: july 28,2017
 *Description: this is the abstract planet class
 * Versions: 0.1 - edited override Tostring()
 **/

namespace Abstract_Planet
{
    /// <summary>
    /// this is abstarct Planet class
    /// </summary>
    public abstract class Planet 
    {
        //private instance variable (fields)
        private double _diameter;
        private double _mass;
        private int _mooncount;
        private string _name;
        private double _orbitalPlanet;
        private int _ringCount;
        private double _rotationPeriod;

        //public properties
        public double Diameter
        {
            get { return this._diameter; }
        }

        public double Mass
        {
            get { return this._mass; }
        }

        public int MoonCount
        {
            get { return this._mooncount; }
            set { this._mooncount = value; }
        }

        public string Name
        {
            get { return this._name; }
        }
        public double OrbitalPeriod
        {
            get { return this._orbitalPlanet; }
            set { this._orbitalPlanet = value; }
        }

        public int RingCount
        {
            get { return this._ringCount; }
            set { this._ringCount = value; }
        }

        public double RotationlPeriod
        {
            get { return this._rotationPeriod; }
            set { this._rotationPeriod = value; }
        }
        //constructor--------------------------------------
        /// <summary>
        /// this is the main constructor for Planet class.
        /// it takes three parameters - name(string) , diameter(double) , mass(double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
       

        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }


        public override string ToString()
        {
            string output = "The Diamter of planet " + this.Name + " is " + this.Diameter + "km " + " and has a mass of " + this.Mass + " x 10^24 kg";
            Console.WriteLine(output);
            Console.WriteLine();
            return output;
        }

    }
}
