namespace ElektroninisDienynas
{
    partial class CreateEntry
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
            this.messageBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.minuteBox = new System.Windows.Forms.TextBox();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.personBox = new System.Windows.Forms.TextBox();
            this.requirementsText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.Location = new System.Drawing.Point(28, 2);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(234, 20);
            this.messageBox.TabIndex = 17;
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createButton.Location = new System.Drawing.Point(105, 79);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 16;
            this.createButton.Text = "Create";
            this.toolTip1.SetToolTip(this.createButton, "Create a new entry with data you just entered");
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // minuteBox
            // 
            this.minuteBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minuteBox.Location = new System.Drawing.Point(220, 53);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(42, 20);
            this.minuteBox.TabIndex = 15;
            // 
            // hourBox
            // 
            this.hourBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hourBox.Location = new System.Drawing.Point(172, 53);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(42, 20);
            this.hourBox.TabIndex = 14;
            // 
            // dayBox
            // 
            this.dayBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayBox.Location = new System.Drawing.Point(124, 53);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(42, 20);
            this.dayBox.TabIndex = 13;
            // 
            // monthBox
            // 
            this.monthBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthBox.Location = new System.Drawing.Point(76, 53);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(42, 20);
            this.monthBox.TabIndex = 12;
            // 
            // yearBox
            // 
            this.yearBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearBox.Location = new System.Drawing.Point(28, 53);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(42, 20);
            this.yearBox.TabIndex = 11;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(25, 134);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(234, 82);
            this.listBox.TabIndex = 18;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(25, 223);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add requirements";
            this.toolTip1.SetToolTip(this.addButton, "Add a new requirement");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(187, 222);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cancelButton, "Go back to previous screen");
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(106, 223);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 21;
            this.removeButton.Text = "Remove";
            this.toolTip1.SetToolTip(this.removeButton, "Remove selected requirement from the list");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // personBox
            // 
            this.personBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personBox.Location = new System.Drawing.Point(28, 27);
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(234, 20);
            this.personBox.TabIndex = 22;
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
            // CreateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.requirementsText);
            this.Controls.Add(this.personBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.yearBox);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "CreateEntry";
            this.Text = "New Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox personBox;
        private System.Windows.Forms.TextBox requirementsText;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}