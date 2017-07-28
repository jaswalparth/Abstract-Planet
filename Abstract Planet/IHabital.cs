using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: Parth Jaswal
 * date:july 28, 2017
 * description: this is an interface that defines a Habital property which must be implmented in any class that subscribr to it
 * version:0.1- created interface IHabital.
 */
namespace Abstract_Planet
{
    /// <summary>
    /// it is a IHabital interface
    /// </summary>
    public interface IHabital
    {
        //public property
        bool Habitable();
    }
}
