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
using ServerChat.Utils;

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
            updateNumberOfUsers();
            updateNumberOfMessages();
            updatePortNumber();
        }

        public void updatePortNumber() 
        {
            string value = Singleton.getInstance().Port.ToString();
            port.Text = formatString(Constants.PORT_LABEL, value);
        }

        public void updateNumberOfUsers() 
        {
            int currentNumberOfUsers = Controllers.Manager.NumberOfUsers;
            totalOfUsers.Text = formatString(Constants.TOTAL_USERS_LABEL, currentNumberOfUsers.ToString()); 
        }

        public void updateNumberOfMessages()
        {
            int currentNumberOfMessages = Controllers.Manager.NumberOfMessages;
            totalOfMessages.Text = formatString(Constants.TOTAL_MESSAGES_LABEL, currentNumberOfMessages.ToString());
        }

        public string formatString(string field, string value) 
        {
            return field + ": " + value;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsView settingsView = new SettingsView();
            settingsView.Show();
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
