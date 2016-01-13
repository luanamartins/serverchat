using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerChat.Controllers
{
    class ServerConfiguration
    {
        public int Port { get; set; }

        public static ServerConfiguration singleton;

        public static ServerConfiguration getInstance() 
        {
            if (singleton == null) {
                singleton = new ServerConfiguration();
            }
            return singleton;
        }
        
    }
}
