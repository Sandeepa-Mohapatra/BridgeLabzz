// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdapteeC.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Adapter
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Adapte Class
    /// </summary>
    class AdapteeC
    {
        /// <summary>
        /// Gets the namelist.
        /// </summary>
        /// <returns>The name list</returns>
        public String[] GetNamelist()
        {
            String[] arr = new string[4];
            arr[0] = "San";
            arr[1] = "Maan";
            arr[2] = "sanna";
            arr[3] = "Naina";
            return arr;
        }
    }
}
