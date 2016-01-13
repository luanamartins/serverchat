using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ServerChat.Controllers;

namespace ServerChat.Views
{
    public partial class SettingsView : Form
    {
        public SettingsView()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ServerConfiguration.getInstance().Port = Convert.ToInt32(portSettingTextBox.Text);
                this.Close();
            }
            catch (Exception ex) 
            {
                // TODO
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
