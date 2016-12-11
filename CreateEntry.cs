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
    public partial class CreateEntry : Form
    {

        public delegate void EntryListChangedHandler(CreateEntry sender, EntryListChangedEventArgs e);
        public event EntryListChangedHandler EntryListChanged;

        public Main form;
        public EntryList requirements = new EntryList();
        public Entry newEntry;
        public List<string> stringList = new List<string>();

        public CreateEntry(Main form)
        {
            InitializeComponent();
            this.form = form;
            yearBox.Text = DateTime.Now.Year.ToString();
            monthBox.Text = DateTime.Now.Month.ToString();
            dayBox.Text = DateTime.Now.Day.ToString();
            hourBox.Text = DateTime.Now.AddHours(1).Hour.ToString();
            minuteBox.Text = DateTime.Now.Minute.ToString();
            personBox.Text = "Person";
            messageBox.Text = "Message";
        }

        public void AddEntry()
        {
            newEntry = new Entry(new DateTime(
                year: Int32.Parse(yearBox.Text), 
                month: Int32.Parse(monthBox.Text),
                day: Int32.Parse(dayBox.Text), 
                hour: Int32.Parse(hourBox.Text),
                minute: Int32.Parse(minuteBox.Text), 
                second: 0), 
                message: messageBox.Text,
                person: personBox.Text, 
                requirements: requirements);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddEntry();
                EntryListChanged(this, new EntryListChangedEventArgs(newEntry));    
                Close();
            }
            catch(BeforeNowException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Wrong input data", "Error", MessageBoxButtons.OK);
            }          
        }

        private void ChooseRequirementsFormClosingHandler(object sender, FormClosingEventArgs e)
        {
            Visible = true;
            Reload();
        }

        private void chooseButton_Click(object sender, EventArgs e)
        {
            ChooseRequirement chooseRequirements = new ChooseRequirement(this);
            chooseRequirements.Visible = true;
            chooseRequirements.FormClosing += ChooseRequirementsFormClosingHandler;
            Visible = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Reload()
        {
            listBox.DataSource = null;
            listBox.DataSource = stringList;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                requirements.RemoveAt(listBox.SelectedIndex);
                stringList.RemoveAt(listBox.SelectedIndex);
            }
            catch { }
            Reload();
        }
    }
}
