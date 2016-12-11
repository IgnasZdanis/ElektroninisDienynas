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
    public partial class ViewEntry : Form
    {
        public Main form;
        int Selected;
        public int selected
        {
            get { return Selected; }
            set { Selected = value; }
        }
        public List<string> stringList = new List<string>();

        public ViewEntry()
        {
            InitializeComponent();
        }

        public ViewEntry(Main form)
        {
            InitializeComponent();

            Func<DateTime, int> GetDaysRemaining = delegate (DateTime dateTime)
            {
                DateTime now = DateTime.Now;
                return (dateTime - now).Days;
            };

            this.form = form;
            
            for (int i=0; i<form.entryList.Count(); i++)
            {
                if (form.dataSource[form.listBox2.SelectedIndex] == form.entryList[i].ToString())
                {
                    selected = i;
                    break;
                }
            }
            messageBox.Text = form.entryList[selected].ToString();
            personBox.Text = form.entryList[selected].person;
            foreach (var entry in form.entryList[selected].requirements.Value)
            {
                stringList.Add(entry.ToString());
            }
            listBox1.DataSource = null;
            listBox1.DataSource = stringList;
            daysRemainingBox.Text = "Days remaing: " + GetDaysRemaining(form.entryList[selected].dateTime).ToString();       
        }

        

        public ViewEntry(Main form, int index)
        {
            InitializeComponent();
            this.form = form;
            selected = index;
            messageBox.Text = form.entryList[selected].ToString();
            foreach (var entry in form.entryList[selected].requirements.Value)
            {
                stringList.Add(entry.ToString());
            }
            listBox1.DataSource = null;
            listBox1.DataSource = stringList;
            daysRemainingBox.Text = "Days remaing: " + form.entryList[selected].dateTime.daysRemaining().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void ViewEntry_Load(object sender, EventArgs e)
        {

        }

        private void ViewEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Visible = true;
            form.WindowState = FormWindowState.Normal;
            form.ShowInTaskbar = true;
            form.entryList.Sort();
            form.Reload();
            form.searchBox.Text = "";
            DateTime now = DateTime.Now;
            /*
            for (int i = 0; i < form.entryList.Count(); i++)
            {
                if (form.entryList[i].dateTime < now)
                { 
                    DeadlineForm deadlineForm = new DeadlineForm(form, form.entryList[i], i);
                    form.WindowState = FormWindowState.Minimized;
                    form.ShowInTaskbar = false;
                    deadlineForm.Visible = true;
                    break;
                }
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateEntry updateEntry = new UpdateEntry(this);
            Visible = false;
            updateEntry.Visible = true;
        }

        public void CloseWindow()
        {
            form.ShowInTaskbar = true;
            Close();
            form.entryList.Sort();
            form.Reload();
            form.searchBox.Text = "";
        }

        public void Reload()
        {
            Func<DateTime, int> GetDaysRemaining = delegate (DateTime dateTime)
            {
                DateTime now = DateTime.Now;
                return (dateTime - now).Days;
            };
            listBox1.DataSource = null;
            listBox1.DataSource = stringList;
            messageBox.Text = form.entryList[selected].ToString();
            daysRemainingBox.Text = "Days remaing: " + GetDaysRemaining(form.entryList[selected].dateTime).ToString();
            personBox.Text = form.entryList[selected].person;
        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void daysRemainingBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
