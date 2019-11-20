using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPtternPrograms.SingleTon
{
    class StaticBlockInitialization
    {
        static int objcount = 0;
        private static StaticBlockInitialization obj;
        private StaticBlockInitialization()
        {
            objcount++;
            Console.WriteLine("Objct Created");
        }
        static {
               
               }
        public static StaticBlockInitialization Obj
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
