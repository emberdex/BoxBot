using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace BoxBot
{
    /// <summary>
    /// BoxBot server add dialog form.
    /// </summary>
    public partial class BoxBotAddServerDialog : Form
    {
        /// <summary>
        /// The Server object produced by the form.
        /// </summary>
        BoxBotServer Server;

        /// <summary>
        /// The constructor for the form.
        /// </summary>
        public BoxBotAddServerDialog()
        {
            // Initialise all objects on the form.
            InitializeComponent();
            
            // Add event handlers for when the radio buttons are changed, to enable/disable certain GUI elements.
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

            // Set default radio button manually.
            this.PasswordRadioButton.Checked = true;

            // Event handler for clicking the Browse button on the form.
            this.PrivateKeyBrowseButton.Click += (sender, e) =>
            {
                this.PrivateKeyOpenFileDialog.ShowDialog();
                this.PrivateKeyPathBox.Text = this.PrivateKeyOpenFileDialog.InitialDirectory +
                                              this.PrivateKeyOpenFileDialog.FileName;
            };

        }

        /// <summary>
        /// Event handler for the Add button.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event parameters.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Create different types of BoxBotServer object based on the inputted data.
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
            // Close this form.
            this.Close();
        }
    }
}
