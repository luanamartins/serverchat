using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerChat.Controllers
{
    class Singleton
    {
        public int Port { get; set; }

        public static Singleton singleton;

        public static Singleton getInstance() 
        {
            if (singleton == null) {
                singleton = new Singleton();
            }
            return singleton;
        }
        
    }
}
