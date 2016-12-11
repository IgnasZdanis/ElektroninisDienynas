using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektroninisDienynas
{
    public partial class SaveForm : Form
    {
        Main main;

        public SaveForm()
        {
            InitializeComponent();
        }

        public SaveForm(Main main)
        {       
            InitializeComponent();
            this.main = main;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            main.save();
            Close();
            main.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Close();
            main.Close();
        }

        private void SaveForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Close();
        }
    }
}
