using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BoxBot
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Application version.
        /// </summary>
        public static float version = 0.1F;

        /// <summary>
        /// Function to write to the log.
        /// </summary>
        /// <param name="line">The value to write.</param>
        public void WriteToLog(string line)
        {
            this._BoxBotLogBox.Text += line + "\n";
        }

        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public MainForm()
        {
            // Initialise all form components.
            InitializeComponent();

            // Do some initial UI housekeeping stuff.
            if (this._BoxBotTargetList.Items.Count == 0)
            {
                this._BoxBotClearTargetsButton.Enabled = false;
                this._BoxBotGoButton.Enabled = false;
            }

            this.Text = String.Format(this.Text, version);

            // Write something to the log.
            WriteToLog(String.Format("[{0}] Starting BoxBot.", 
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));

            // Display a warning error message.
            MessageBox.Show("This is pre-alpha software and doesn't work in its current state.",
                "BoxBot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void _BoxBotGoButton_Click(object sender, EventArgs e)
        {
            // TODO: implement proper running logic
            throw new NotImplementedException();
        }

        private void _BoxBotAddTargetsButton_Click(object sender, EventArgs e)
        {
            BoxBotAddServerDialog frm = new BoxBotAddServerDialog();
            frm.ShowDialog();
        }
    }
}
