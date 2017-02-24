namespace BoxBot
{
    partial class MainForm
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
            this._BoxBotTitleLabel = new System.Windows.Forms.Label();
            this._BoxBotContainer = new System.Windows.Forms.SplitContainer();
            this._BoxBotStatusStrip = new System.Windows.Forms.StatusStrip();
            this._BoxBotStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._BoxBotGoButton = new System.Windows.Forms.Button();
            this._BoxBotTargetGroup = new System.Windows.Forms.GroupBox();
            this._BoxBotTargetList = new System.Windows.Forms.ListBox();
            this._BoxBotAddTargetsButton = new System.Windows.Forms.Button();
            this._BoxBotClearTargetsButton = new System.Windows.Forms.Button();
            this._BoxBotIssueGroup = new System.Windows.Forms.GroupBox();
            this._BoxBotCommandTextBox = new System.Windows.Forms.TextBox();
            this._BoxBotLogContainer = new System.Windows.Forms.GroupBox();
            this._BoxBotLogBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._BoxBotContainer)).BeginInit();
            this._BoxBotContainer.Panel1.SuspendLayout();
            this._BoxBotContainer.Panel2.SuspendLayout();
            this._BoxBotContainer.SuspendLayout();
            this._BoxBotStatusStrip.SuspendLayout();
            this._BoxBotTargetGroup.SuspendLayout();
            this._BoxBotIssueGroup.SuspendLayout();
            this._BoxBotLogContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _BoxBotTitleLabel
            // 
            this._BoxBotTitleLabel.AutoSize = true;
            this._BoxBotTitleLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BoxBotTitleLabel.Location = new System.Drawing.Point(12, 9);
            this._BoxBotTitleLabel.Name = "_BoxBotTitleLabel";
            this._BoxBotTitleLabel.Size = new System.Drawing.Size(180, 56);
            this._BoxBotTitleLabel.TabIndex = 0;
            this._BoxBotTitleLabel.Text = "BoxBot";
            // 
            // _BoxBotContainer
            // 
            this._BoxBotContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._BoxBotContainer.Location = new System.Drawing.Point(0, 0);
            this._BoxBotContainer.Name = "_BoxBotContainer";
            // 
            // _BoxBotContainer.Panel1
            // 
            this._BoxBotContainer.Panel1.Controls.Add(this._BoxBotStatusStrip);
            this._BoxBotContainer.Panel1.Controls.Add(this._BoxBotGoButton);
            this._BoxBotContainer.Panel1.Controls.Add(this._BoxBotTargetGroup);
            this._BoxBotContainer.Panel1.Controls.Add(this._BoxBotIssueGroup);
            this._BoxBotContainer.Panel1.Controls.Add(this._BoxBotTitleLabel);
            // 
            // _BoxBotContainer.Panel2
            // 
            this._BoxBotContainer.Panel2.Controls.Add(this._BoxBotLogContainer);
            this._BoxBotContainer.Size = new System.Drawing.Size(975, 510);
            this._BoxBotContainer.SplitterDistance = 325;
            this._BoxBotContainer.TabIndex = 1;
            // 
            // _BoxBotStatusStrip
            // 
            this._BoxBotStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._BoxBotStatusLabel});
            this._BoxBotStatusStrip.Location = new System.Drawing.Point(0, 488);
            this._BoxBotStatusStrip.Name = "_BoxBotStatusStrip";
            this._BoxBotStatusStrip.Size = new System.Drawing.Size(325, 22);
            this._BoxBotStatusStrip.SizingGrip = false;
            this._BoxBotStatusStrip.TabIndex = 4;
            this._BoxBotStatusStrip.Text = "statusStrip1";
            // 
            // _BoxBotStatusLabel
            // 
            this._BoxBotStatusLabel.Name = "_BoxBotStatusLabel";
            this._BoxBotStatusLabel.Size = new System.Drawing.Size(162, 17);
            this._BoxBotStatusLabel.Text = "Ready and reporting for duty.";
            // 
            // _BoxBotGoButton
            // 
            this._BoxBotGoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BoxBotGoButton.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this._BoxBotGoButton.Location = new System.Drawing.Point(199, 13);
            this._BoxBotGoButton.Name = "_BoxBotGoButton";
            this._BoxBotGoButton.Size = new System.Drawing.Size(111, 52);
            this._BoxBotGoButton.TabIndex = 3;
            this._BoxBotGoButton.Text = "Go!";
            this._BoxBotGoButton.UseVisualStyleBackColor = true;
            this._BoxBotGoButton.Click += new System.EventHandler(this._BoxBotGoButton_Click);
            // 
            // _BoxBotTargetGroup
            // 
            this._BoxBotTargetGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BoxBotTargetGroup.Controls.Add(this._BoxBotTargetList);
            this._BoxBotTargetGroup.Controls.Add(this._BoxBotAddTargetsButton);
            this._BoxBotTargetGroup.Controls.Add(this._BoxBotClearTargetsButton);
            this._BoxBotTargetGroup.Location = new System.Drawing.Point(22, 123);
            this._BoxBotTargetGroup.Name = "_BoxBotTargetGroup";
            this._BoxBotTargetGroup.Size = new System.Drawing.Size(288, 350);
            this._BoxBotTargetGroup.TabIndex = 1;
            this._BoxBotTargetGroup.TabStop = false;
            this._BoxBotTargetGroup.Text = "To these servers:";
            // 
            // _BoxBotTargetList
            // 
            this._BoxBotTargetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BoxBotTargetList.FormattingEnabled = true;
            this._BoxBotTargetList.IntegralHeight = false;
            this._BoxBotTargetList.ItemHeight = 14;
            this._BoxBotTargetList.Location = new System.Drawing.Point(7, 22);
            this._BoxBotTargetList.Name = "_BoxBotTargetList";
            this._BoxBotTargetList.Size = new System.Drawing.Size(275, 293);
            this._BoxBotTargetList.TabIndex = 1;
            // 
            // _BoxBotAddTargetsButton
            // 
            this._BoxBotAddTargetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._BoxBotAddTargetsButton.Location = new System.Drawing.Point(207, 321);
            this._BoxBotAddTargetsButton.Name = "_BoxBotAddTargetsButton";
            this._BoxBotAddTargetsButton.Size = new System.Drawing.Size(75, 23);
            this._BoxBotAddTargetsButton.TabIndex = 0;
            this._BoxBotAddTargetsButton.Text = "Add...";
            this._BoxBotAddTargetsButton.UseVisualStyleBackColor = true;
            this._BoxBotAddTargetsButton.Click += new System.EventHandler(this._BoxBotAddTargetsButton_Click);
            // 
            // _BoxBotClearTargetsButton
            // 
            this._BoxBotClearTargetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._BoxBotClearTargetsButton.Location = new System.Drawing.Point(6, 321);
            this._BoxBotClearTargetsButton.Name = "_BoxBotClearTargetsButton";
            this._BoxBotClearTargetsButton.Size = new System.Drawing.Size(75, 23);
            this._BoxBotClearTargetsButton.TabIndex = 0;
            this._BoxBotClearTargetsButton.Text = "Clear";
            this._BoxBotClearTargetsButton.UseVisualStyleBackColor = true;
            // 
            // _BoxBotIssueGroup
            // 
            this._BoxBotIssueGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BoxBotIssueGroup.Controls.Add(this._BoxBotCommandTextBox);
            this._BoxBotIssueGroup.Location = new System.Drawing.Point(22, 69);
            this._BoxBotIssueGroup.Name = "_BoxBotIssueGroup";
            this._BoxBotIssueGroup.Size = new System.Drawing.Size(288, 48);
            this._BoxBotIssueGroup.TabIndex = 1;
            this._BoxBotIssueGroup.TabStop = false;
            this._BoxBotIssueGroup.Text = "Issue this command:";
            // 
            // _BoxBotCommandTextBox
            // 
            this._BoxBotCommandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BoxBotCommandTextBox.Location = new System.Drawing.Point(6, 18);
            this._BoxBotCommandTextBox.Name = "_BoxBotCommandTextBox";
            this._BoxBotCommandTextBox.Size = new System.Drawing.Size(276, 22);
            this._BoxBotCommandTextBox.TabIndex = 0;
            // 
            // _BoxBotLogContainer
            // 
            this._BoxBotLogContainer.Controls.Add(this._BoxBotLogBox);
            this._BoxBotLogContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._BoxBotLogContainer.Location = new System.Drawing.Point(0, 0);
            this._BoxBotLogContainer.Name = "_BoxBotLogContainer";
            this._BoxBotLogContainer.Size = new System.Drawing.Size(646, 510);
            this._BoxBotLogContainer.TabIndex = 0;
            this._BoxBotLogContainer.TabStop = false;
            this._BoxBotLogContainer.Text = "Log:";
            // 
            // _BoxBotLogBox
            // 
            this._BoxBotLogBox.BackColor = System.Drawing.Color.White;
            this._BoxBotLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._BoxBotLogBox.Enabled = false;
            this._BoxBotLogBox.Location = new System.Drawing.Point(3, 18);
            this._BoxBotLogBox.Margin = new System.Windows.Forms.Padding(10);
            this._BoxBotLogBox.Multiline = true;
            this._BoxBotLogBox.Name = "_BoxBotLogBox";
            this._BoxBotLogBox.Size = new System.Drawing.Size(640, 489);
            this._BoxBotLogBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 510);
            this.Controls.Add(this._BoxBotContainer);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(991, 549);
            this.Name = "MainForm";
            this.Text = "BoxBot - monotron, v{0}";
            this._BoxBotContainer.Panel1.ResumeLayout(false);
            this._BoxBotContainer.Panel1.PerformLayout();
            this._BoxBotContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._BoxBotContainer)).EndInit();
            this._BoxBotContainer.ResumeLayout(false);
            this._BoxBotStatusStrip.ResumeLayout(false);
            this._BoxBotStatusStrip.PerformLayout();
            this._BoxBotTargetGroup.ResumeLayout(false);
            this._BoxBotIssueGroup.ResumeLayout(false);
            this._BoxBotIssueGroup.PerformLayout();
            this._BoxBotLogContainer.ResumeLayout(false);
            this._BoxBotLogContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _BoxBotTitleLabel;
        private System.Windows.Forms.SplitContainer _BoxBotContainer;
        private System.Windows.Forms.GroupBox _BoxBotIssueGroup;
        private System.Windows.Forms.GroupBox _BoxBotTargetGroup;
        private System.Windows.Forms.TextBox _BoxBotCommandTextBox;
        private System.Windows.Forms.Button _BoxBotAddTargetsButton;
        private System.Windows.Forms.Button _BoxBotClearTargetsButton;
        private System.Windows.Forms.ListBox _BoxBotTargetList;
        private System.Windows.Forms.Button _BoxBotGoButton;
        private System.Windows.Forms.GroupBox _BoxBotLogContainer;
        private System.Windows.Forms.StatusStrip _BoxBotStatusStrip;
        private System.Windows.Forms.TextBox _BoxBotLogBox;
        private System.Windows.Forms.ToolStripStatusLabel _BoxBotStatusLabel;
    }
}

