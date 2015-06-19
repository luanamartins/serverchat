using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServerChat
{
    public partial class Form1 : Form
    {
        public RichTextBox displayRichTextBox 
        {
            get {
                return displayOnlineUsers;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void changeNumberOfUsers() 
        {
            int currentNumberOfUsers = Controllers.Manager.NumberOfUsers;
            totalOfUsers.Text = "Total of users: " + currentNumberOfUsers; 
        }

        public void changeNumberOfMessages()
        {
            int currentNumberOfMessages = Controllers.Manager.NumberOfMessages;
            totalOfMessages.Text = "Total of messages: " + currentNumberOfMessages;
        }



    }
}
