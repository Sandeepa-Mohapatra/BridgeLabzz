// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AdapterC.cs" company="Bridgelabz">
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
    /// It is the intermediate between client and Adapte class
    /// It implements interface and inherit Adapte calss
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.Adapter.AdapteeC" />
    /// <seealso cref="DesignPtternPrograms.Adapter.ITarget" />
    class AdapterC :AdapteeC, ITarget
    {
        /// <summary>
        /// Append a message with every name
        /// </summary>
        /// <returns>name</returns>
        public String[] GetStudentName()
        {
            String[] arr = GetNamelist();
            for(int i=0;i<4;i++)
            {
                arr[i] = "Have a good day"+" "+arr[i];
            }
            return arr;
        }
    }
}
