namespace ServerChat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.displayOnlineUsers = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalOfUsers = new System.Windows.Forms.Label();
            this.totalOfMessages = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayOnlineUsers
            // 
            this.displayOnlineUsers.Location = new System.Drawing.Point(12, 33);
            this.displayOnlineUsers.Name = "displayOnlineUsers";
            this.displayOnlineUsers.Size = new System.Drawing.Size(169, 255);
            this.displayOnlineUsers.TabIndex = 0;
            this.displayOnlineUsers.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online users";
            // 
            // totalOfUsers
            // 
            this.totalOfUsers.AutoSize = true;
            this.totalOfUsers.Location = new System.Drawing.Point(225, 33);
            this.totalOfUsers.Name = "totalOfUsers";
            this.totalOfUsers.Size = new System.Drawing.Size(77, 13);
            this.totalOfUsers.TabIndex = 2;
            this.totalOfUsers.Text = "Total of users: ";
            // 
            // totalOfMessages
            // 
            this.totalOfMessages.AutoSize = true;
            this.totalOfMessages.Location = new System.Drawing.Point(225, 60);
            this.totalOfMessages.Name = "totalOfMessages";
            this.totalOfMessages.Size = new System.Drawing.Size(99, 13);
            this.totalOfMessages.TabIndex = 3;
            this.totalOfMessages.Text = "Total of messages: ";
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(496, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 300);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.totalOfMessages);
            this.Controls.Add(this.totalOfUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayOnlineUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox displayOnlineUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalOfUsers;
        private System.Windows.Forms.Label totalOfMessages;
        private System.Windows.Forms.Button settingsButton;




    }
}

