using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServerChat.Views;
using ServerChat.Controllers;

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
            this.Activated += new EventHandler(Form1_Activated);
        }

        void Form1_Activated(object sender, EventArgs e)
        {
            updateFields();
        }

        public void updateFields() 
        {
            changeNumberOfUsers();
            changeNumberOfMessages();
            updatePortNumber();
        }

        public void updatePortNumber() 
        {
            port.Text = "Port: " + Singleton.getInstance().Port;
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

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsView settingsView = new SettingsView();
            settingsView.Show();
        }
    }
}
