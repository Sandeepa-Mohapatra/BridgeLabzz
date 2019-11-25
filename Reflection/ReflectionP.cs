// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ReflectionP.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    /// <summary>
    /// Class for reflection
    /// </summary>
    class ReflectionP
    {
        /// <summary>
        /// Shows this instance.
        /// </summary>
        public void Show()
        {
            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                // Display each type 
                Console.WriteLine();
                Console.WriteLine("Class : {0}", item.Name);

                // Array to store methods 
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method 
                    Console.WriteLine();
                    Console.WriteLine(" Method : {0}", method.Name);

                    // Array to store parameters 
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine();
                        Console.WriteLine("Parameter : {0} Type : {1}", arg.Name, arg.ParameterType);
                    }
                }
            }
        }
    }
}
