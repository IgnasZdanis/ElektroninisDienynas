namespace ElektroninisDienynas
{
    partial class ViewEntry
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.daysRemainingBox = new System.Windows.Forms.TextBox();
            this.personBox = new System.Windows.Forms.TextBox();
            this.requirementsText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(337, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Back";
            this.toolTip1.SetToolTip(this.button3, "Go back to previous screen");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(25, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Edit";
            this.toolTip1.SetToolTip(this.button2, "Make changes to this entry");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(387, 95);
            this.listBox1.TabIndex = 28;
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.Enabled = false;
            this.messageBox.Location = new System.Drawing.Point(25, 25);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(387, 20);
            this.messageBox.TabIndex = 27;
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // daysRemainingBox
            // 
            this.daysRemainingBox.Enabled = false;
            this.daysRemainingBox.Location = new System.Drawing.Point(25, 51);
            this.daysRemainingBox.Name = "daysRemainingBox";
            this.daysRemainingBox.Size = new System.Drawing.Size(110, 20);
            this.daysRemainingBox.TabIndex = 31;
            this.daysRemainingBox.TextChanged += new System.EventHandler(this.daysRemainingBox_TextChanged);
            // 
            // personBox
            // 
            this.personBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personBox.Enabled = false;
            this.personBox.Location = new System.Drawing.Point(141, 51);
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(271, 20);
            this.personBox.TabIndex = 32;
            // 
            // requirementsText
            // 
            this.requirementsText.Enabled = false;
            this.requirementsText.Location = new System.Drawing.Point(25, 83);
            this.requirementsText.Name = "requirementsText";
            this.requirementsText.Size = new System.Drawing.Size(116, 20);
            this.requirementsText.TabIndex = 33;
            this.requirementsText.Text = "Requirements:";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // ViewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 240);
            this.Controls.Add(this.requirementsText);
            this.Controls.Add(this.personBox);
            this.Controls.Add(this.daysRemainingBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.messageBox);
            this.MinimumSize = new System.Drawing.Size(440, 279);
            this.Name = "ViewEntry";
            this.Text = "Selected Entry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewEntry_FormClosed);
            this.Load += new System.EventHandler(this.ViewEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox daysRemainingBox;
        private System.Windows.Forms.TextBox personBox;
        private System.Windows.Forms.TextBox requirementsText;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}