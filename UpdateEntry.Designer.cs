namespace ElektroninisDienynas
{
    partial class UpdateEntry
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
            this.components = new System.ComponentModel.Container();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddReqButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.personBox = new System.Windows.Forms.TextBox();
            this.requirementsText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(185, 222);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(74, 23);
            this.CancelButton.TabIndex = 30;
            this.CancelButton.Text = "Cancel";
            this.toolTip1.SetToolTip(this.CancelButton, "Go back to previous screen");
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddReqButton
            // 
            this.AddReqButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddReqButton.Location = new System.Drawing.Point(24, 223);
            this.AddReqButton.Name = "AddReqButton";
            this.AddReqButton.Size = new System.Drawing.Size(74, 23);
            this.AddReqButton.TabIndex = 29;
            this.AddReqButton.Text = "Add";
            this.toolTip1.SetToolTip(this.AddReqButton, "Add a new requirement");
            this.AddReqButton.UseVisualStyleBackColor = true;
            this.AddReqButton.Click += new System.EventHandler(this.ChooseReqButton_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(24, 134);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(234, 82);
            this.listBox.TabIndex = 28;
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.Location = new System.Drawing.Point(25, 3);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(234, 20);
            this.messageBox.TabIndex = 27;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpdateButton.Location = new System.Drawing.Point(105, 81);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 26;
            this.UpdateButton.Text = "Update";
            this.toolTip1.SetToolTip(this.UpdateButton, "Update existing entry with the changes you just made");
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // minuteBox
            // 
            this.minuteBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minuteBox.Location = new System.Drawing.Point(217, 55);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(42, 20);
            this.minuteBox.TabIndex = 25;
            // 
            // hourBox
            // 
            this.hourBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hourBox.Location = new System.Drawing.Point(169, 55);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(42, 20);
            this.hourBox.TabIndex = 24;
            // 
            // dayBox
            // 
            this.dayBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayBox.Location = new System.Drawing.Point(121, 55);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(42, 20);
            this.dayBox.TabIndex = 23;
            // 
            // monthBox
            // 
            this.monthBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthBox.Location = new System.Drawing.Point(73, 55);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(42, 20);
            this.monthBox.TabIndex = 22;
            // 
            // yearBox
            // 
            this.yearBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearBox.Location = new System.Drawing.Point(25, 55);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(42, 20);
            this.yearBox.TabIndex = 21;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(104, 222);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 31;
            this.removeButton.Text = "Remove";
            this.toolTip1.SetToolTip(this.removeButton, "Remove selected requirement from the list");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // personBox
            // 
            this.personBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personBox.Location = new System.Drawing.Point(25, 29);
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(234, 20);
            this.personBox.TabIndex = 32;
            // 
            // requirementsText
            // 
            this.requirementsText.Enabled = false;
            this.requirementsText.Location = new System.Drawing.Point(25, 108);
            this.requirementsText.Name = "requirementsText";
            this.requirementsText.Size = new System.Drawing.Size(116, 20);
            this.requirementsText.TabIndex = 34;
            this.requirementsText.Text = "Requirements:";
            // 
            // UpdateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.requirementsText);
            this.Controls.Add(this.personBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddReqButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.yearBox);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "UpdateEntry";
            this.Text = "Update Entry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateEntry_FormClosed);
            this.Load += new System.EventHandler(this.UpdateEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddReqButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox personBox;
        private System.Windows.Forms.TextBox requirementsText;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}