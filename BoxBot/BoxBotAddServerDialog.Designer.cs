namespace BoxBot
{
    partial class BoxBotAddServerDialog
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
            this.NameGroup = new System.Windows.Forms.GroupBox();
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.UsernameRadioButton = new System.Windows.Forms.GroupBox();
            this.PrivateKeyBrowseButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PrivateKeyPathBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PathTextBox = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PubKeyRadioButton = new System.Windows.Forms.RadioButton();
            this.PasswordRadioButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.PrivateKeyOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.NameGroup.SuspendLayout();
            this.UsernameRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameGroup
            // 
            this.NameGroup.Controls.Add(this.HostTextBox);
            this.NameGroup.Location = new System.Drawing.Point(15, 14);
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.Size = new System.Drawing.Size(517, 44);
            this.NameGroup.TabIndex = 0;
            this.NameGroup.TabStop = false;
            this.NameGroup.Text = "Enter the hostname or the IP address of the server:";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(6, 16);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(505, 22);
            this.HostTextBox.TabIndex = 0;
            // 
            // UsernameRadioButton
            // 
            this.UsernameRadioButton.Controls.Add(this.PrivateKeyBrowseButton);
            this.UsernameRadioButton.Controls.Add(this.PasswordTextBox);
            this.UsernameRadioButton.Controls.Add(this.PrivateKeyPathBox);
            this.UsernameRadioButton.Controls.Add(this.PasswordLabel);
            this.UsernameRadioButton.Controls.Add(this.UsernameTextBox);
            this.UsernameRadioButton.Controls.Add(this.PathTextBox);
            this.UsernameRadioButton.Controls.Add(this.UsernameLabel);
            this.UsernameRadioButton.Controls.Add(this.PubKeyRadioButton);
            this.UsernameRadioButton.Controls.Add(this.PasswordRadioButton);
            this.UsernameRadioButton.Location = new System.Drawing.Point(15, 64);
            this.UsernameRadioButton.Name = "UsernameRadioButton";
            this.UsernameRadioButton.Size = new System.Drawing.Size(517, 123);
            this.UsernameRadioButton.TabIndex = 0;
            this.UsernameRadioButton.TabStop = false;
            this.UsernameRadioButton.Text = "Authenticate with:";
            // 
            // PrivateKeyBrowseButton
            // 
            this.PrivateKeyBrowseButton.Location = new System.Drawing.Point(416, 40);
            this.PrivateKeyBrowseButton.Name = "PrivateKeyBrowseButton";
            this.PrivateKeyBrowseButton.Size = new System.Drawing.Size(95, 23);
            this.PrivateKeyBrowseButton.TabIndex = 2;
            this.PrivateKeyBrowseButton.Text = "Browse...";
            this.PrivateKeyBrowseButton.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(158, 88);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(353, 22);
            this.PasswordTextBox.TabIndex = 0;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PrivateKeyPathBox
            // 
            this.PrivateKeyPathBox.Location = new System.Drawing.Point(158, 41);
            this.PrivateKeyPathBox.Name = "PrivateKeyPathBox";
            this.PrivateKeyPathBox.Size = new System.Drawing.Size(252, 22);
            this.PrivateKeyPathBox.TabIndex = 0;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(155, 71);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(70, 14);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(6, 88);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(133, 22);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // PathTextBox
            // 
            this.PathTextBox.AutoSize = true;
            this.PathTextBox.Location = new System.Drawing.Point(155, 24);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(147, 14);
            this.PathTextBox.TabIndex = 1;
            this.PathTextBox.Text = "Path to private key:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(6, 71);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 14);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            // 
            // PubKeyRadioButton
            // 
            this.PubKeyRadioButton.AutoSize = true;
            this.PubKeyRadioButton.Location = new System.Drawing.Point(6, 46);
            this.PubKeyRadioButton.Name = "PubKeyRadioButton";
            this.PubKeyRadioButton.Size = new System.Drawing.Size(95, 18);
            this.PubKeyRadioButton.TabIndex = 0;
            this.PubKeyRadioButton.TabStop = true;
            this.PubKeyRadioButton.Text = "Public Key";
            this.PubKeyRadioButton.UseVisualStyleBackColor = true;
            // 
            // PasswordRadioButton
            // 
            this.PasswordRadioButton.AutoSize = true;
            this.PasswordRadioButton.Location = new System.Drawing.Point(7, 22);
            this.PasswordRadioButton.Name = "PasswordRadioButton";
            this.PasswordRadioButton.Size = new System.Drawing.Size(81, 18);
            this.PasswordRadioButton.TabIndex = 0;
            this.PasswordRadioButton.TabStop = true;
            this.PasswordRadioButton.Text = "Password";
            this.PasswordRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(451, 193);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PrivateKeyOpenFileDialog
            // 
            this.PrivateKeyOpenFileDialog.Filter = "Private key files|*.ppk;*.pem";
            this.PrivateKeyOpenFileDialog.Title = "Select your private key...";
            // 
            // BoxBotAddServerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 226);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.UsernameRadioButton);
            this.Controls.Add(this.NameGroup);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BoxBotAddServerDialog";
            this.Text = "Add Server";
            this.NameGroup.ResumeLayout(false);
            this.NameGroup.PerformLayout();
            this.UsernameRadioButton.ResumeLayout(false);
            this.UsernameRadioButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NameGroup;
        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.GroupBox UsernameRadioButton;
        private System.Windows.Forms.RadioButton PasswordRadioButton;
        private System.Windows.Forms.RadioButton PubKeyRadioButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PathTextBox;
        private System.Windows.Forms.TextBox PrivateKeyPathBox;
        private System.Windows.Forms.Button PrivateKeyBrowseButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.OpenFileDialog PrivateKeyOpenFileDialog;
    }
}