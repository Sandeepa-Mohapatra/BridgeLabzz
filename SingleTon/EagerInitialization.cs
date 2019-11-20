using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPtternPrograms.SingleTon
{
    public class EagerInitialization
    {
        static int objcount = 0;
        private static readonly EagerInitialization obj = new EagerInitialization();
        private EagerInitialization()
        {
            objcount++;
            Console.WriteLine("Objct Created");
        }
        public static EagerInitialization Obj
        {
            get
            {
                return obj;
            }
        }
        public void Message(string message)
        {
            Console.WriteLine("Message " + message);
        }
    }
}
