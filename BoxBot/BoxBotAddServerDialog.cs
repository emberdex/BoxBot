using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace BoxBot
{
    public partial class BoxBotAddServerDialog : Form
    {
        BoxBotServer Server;
        public BoxBotAddServerDialog()
        {
            InitializeComponent();

            this.PubKeyRadioButton.CheckedChanged += (sender, e) =>
            {
                this.PrivateKeyBrowseButton.Enabled = true;
                this.PrivateKeyPathBox.Enabled = true;
            };

            this.PasswordRadioButton.CheckedChanged += (sender, e) =>
            {
                this.PrivateKeyBrowseButton.Enabled = false;
                this.PrivateKeyPathBox.Enabled = false;
            };

            this.PasswordRadioButton.Checked = true;

            this.PrivateKeyBrowseButton.Click += (sender, e) =>
            {
                this.PrivateKeyOpenFileDialog.ShowDialog();
                this.PrivateKeyPathBox.Text = this.PrivateKeyOpenFileDialog.InitialDirectory +
                                              this.PrivateKeyOpenFileDialog.FileName;
            };

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.PubKeyRadioButton.Checked)
            {
                Server = new BoxBotServer(HostTextBox.Text, 22, new BoxBotAuthenticator(
                    UsernameTextBox.Text, PrivateKeyPathBox.Text, PasswordTextBox.Text));
            }
            else
            {
                Server = new BoxBotServer(HostTextBox.Text, 22, new BoxBotAuthenticator(
                    UsernameTextBox.Text, PasswordTextBox.Text));
            }
            this.Close();
        }
    }
}
