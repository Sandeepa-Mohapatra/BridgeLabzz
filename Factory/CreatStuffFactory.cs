// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CreatStuffFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Concrete Creator Class
    /// This class implement the creator class and override the method
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.Factory.StuffFactory" />
    public class CreatStuffFactory:StuffFactory
    {
        /// <summary>
        /// Overrided method
        /// </summary>
        /// <param name="Stuff">The stuff.</param>
        /// <returns></returns>
        public override IFactory GetFactory(String Stuff)
        {
            switch(Stuff)
            {
                case "Book":
                    return new Book();

                case "Pen":
                    return new Pen();

                    break;
            }
            return null ;
        }
    }
}

