using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektroninisDienynas
{
    public partial class DeadlineForm : Form
    {

        Main main;
        int index;

        public DeadlineForm()
        {
            InitializeComponent();
        }

        public DeadlineForm(Main main, Entry entry, int index)
        {         
            InitializeComponent();
            this.main = main;
            this.index = index;
            WindowState = FormWindowState.Normal;
            textBox1.Text = "Entry: \"" + entry.message + "\" has reached a deadline!";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Close();
            main.forDeadlineForm(index);
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            main.entryList.RemoveAt(index);
            foreach (Entry entry in main.entryList)
            {
                for (int i = 0; i < entry.requirements.Value.Count(); i++)
                {
                    if (main.entryList[main.listBox2.SelectedIndex].Equals(entry.requirements.Value[i]))
                    {
                        entry.requirements.Value.RemoveAt(i);
                    }
                }
            }
            main.Reload();
            DateTime now = DateTime.Now;
            for (int i = 0; i < main.entryList.Count(); i++)
            {
                if (main.entryList[i].dateTime < now)
                {
                    textBox1.Text = "Entry: \"" + main.entryList[i].message + "\" has reached a deadline!";
                    return;
                }
            }
            Close();
            
            
        }

        private void DeadlineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.show = true;
            main.Visible = true;
        }
    }
}
