using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerChat.Controllers
{
    class Manager
    {
        public static int NumberOfUsers;
        public static int NumberOfMessages;
        public List<String> listOfOnlineUsers;

        public static void changeNumberUsers(int number) 
        {
            NumberOfUsers = number;
        }

        public static void changeNumberOfMessages(int number) 
        {
            NumberOfMessages = number;    
        }

        public void processRequest() 
        {
               
        }

        public void loginRequest(string username, string password) 
        {
            
        }
    }
}
