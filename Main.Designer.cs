namespace ElektroninisDienynas
{
    partial class Main
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
            this.button2 = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.internetButton = new System.Windows.Forms.Button();
            this.internetBox = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.saveToButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save";
            this.toolTip.SetToolTip(this.button2, "Save your changes");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(1, 35);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(108, 23);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Create Entry";
            this.toolTip.SetToolTip(this.createButton, "Create a new entry");
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.removeButton.Location = new System.Drawing.Point(354, 219);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(108, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove selected";
            this.toolTip.SetToolTip(this.removeButton, "Removes selected entry from the list");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // showButton
            // 
            this.showButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showButton.Location = new System.Drawing.Point(240, 219);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(108, 23);
            this.showButton.TabIndex = 14;
            this.showButton.Text = "Show selected";
            this.toolTip.SetToolTip(this.showButton, "Shows selected entry from the list");
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(433, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(160, 20);
            this.searchBox.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(599, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.toolTip.SetToolTip(this.searchButton, "Search existing entries");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // internetButton
            // 
            this.internetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.internetButton.Location = new System.Drawing.Point(1, 237);
            this.internetButton.Name = "internetButton";
            this.internetButton.Size = new System.Drawing.Size(75, 40);
            this.internetButton.TabIndex = 17;
            this.internetButton.Text = "Load from internet";
            this.toolTip.SetToolTip(this.internetButton, "Load events from any VU MIF group timetable");
            this.internetButton.UseVisualStyleBackColor = true;
            this.internetButton.Click += new System.EventHandler(this.internetButton_Click);
            // 
            // internetBox
            // 
            this.internetBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.internetBox.Location = new System.Drawing.Point(82, 257);
            this.internetBox.Name = "internetBox";
            this.internetBox.Size = new System.Drawing.Size(313, 20);
            this.internetBox.TabIndex = 18;
            this.internetBox.Text = "Internet website";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.Location = new System.Drawing.Point(1, 63);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(240, 33);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(434, 173);
            this.listBox2.TabIndex = 21;
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(553, 221);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 22;
            // 
            // saveToButton
            // 
            this.saveToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveToButton.Location = new System.Drawing.Point(472, 219);
            this.saveToButton.Name = "saveToButton";
            this.saveToButton.Size = new System.Drawing.Size(75, 23);
            this.saveToButton.TabIndex = 23;
            this.saveToButton.Text = "Save To";
            this.toolTip.SetToolTip(this.saveToButton, "Save current list to file or send it to your e-mail");
            this.saveToButton.UseVisualStyleBackColor = true;
            this.saveToButton.Click += new System.EventHandler(this.saveToButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 281);
            this.Controls.Add(this.saveToButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.internetBox);
            this.Controls.Add(this.internetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.button2);
            this.MinimumSize = new System.Drawing.Size(702, 320);
            this.Name = "Main";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Main_ResizeEnd);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button internetButton;
        private System.Windows.Forms.TextBox internetBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        public System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button saveToButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

