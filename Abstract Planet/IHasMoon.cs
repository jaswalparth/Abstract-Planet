using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: Parth Jaswal
 * date: july 28, 2017
 * description: this is a interface that defines a MoonCount property that must be implemented in any class sthat sucbscribe to it
 * version: 0.1 - created interface IHasMoon
 */

namespace Abstract_Planet
{
    /// <summary>
    /// this is IHasMoon interface
    /// </summary>
    interface IHasMoon
    {
        //public property
        bool HasMoon();
    }
}
