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
    public partial class UpdateEntry : Form
    {

        public ViewEntry viewEntry;
        public EntryList requirements;
        public List<string> stringList;
        Entry newEntry;

        public UpdateEntry()
        {
            InitializeComponent();
        }

        public UpdateEntry(ViewEntry form)
        {
            InitializeComponent();
            this.viewEntry = form;
            this.stringList = form.stringList;
            requirements = new EntryList();
            foreach(Entry req in form.form.entryList[form.selected].requirements.Value)
            {
                this.requirements.Add(req);
            }
            messageBox.Text = form.form.entryList[form.selected].message;
            personBox.Text = form.form.entryList[form.selected].person;
            yearBox.Text = form.form.entryList[form.selected].dateTime.Year.ToString();
            monthBox.Text = form.form.entryList[form.selected].dateTime.Month.ToString();
            dayBox.Text = form.form.entryList[form.selected].dateTime.Day.ToString();
            hourBox.Text = form.form.entryList[form.selected].dateTime.Hour.ToString();
            minuteBox.Text = form.form.entryList[form.selected].dateTime.Minute.ToString();
            listBox.DataSource = form.stringList;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        public void CloseWindow()
        {     
            viewEntry.Visible = true;
            Close();
        }

        private void UpdateEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewEntry.Visible = true;
            viewEntry.WindowState = FormWindowState.Normal;
            viewEntry.ShowInTaskbar = true;
        }

        private void ChooseReqButton_Click(object sender, EventArgs e)
        {
            ChooseRequirement chooseRequirements = new ChooseRequirement(this);
            chooseRequirements.Visible = true;
            chooseRequirements.FormClosing += ChooseRequirementsFormClosingHandler;
            Visible = false;
        }

        private void ChooseRequirementsFormClosingHandler(object sender, FormClosingEventArgs e)
        {
            Visible = true;
            Reload();
        }

        public void Reload()
        {
            listBox.DataSource = null;
            listBox.DataSource = stringList;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Add();
                foreach (Entry entry in viewEntry.form.entryList)
                {
                    for (int i = 0; i < entry.requirements.Value.Count(); i++)
                    {
                        if (entry.requirements.Value[i].Equals(viewEntry.form.entryList[viewEntry.selected]))
                        {
                            entry.requirements.Value.RemoveAt(i);
                        }
                    }
                }
                viewEntry.form.entryList.RemoveAt(viewEntry.selected);
                viewEntry.form.Reload();
                viewEntry.Reload();
                CloseWindow();
            }

            catch (BeforeNowException exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK);
            }

            catch
            {
                MessageBox.Show("Wrong input data", "Error", MessageBoxButtons.OK);
            }
        }

        public void Add()
        {
            newEntry = new Entry( new DateTime(
                year: Int32.Parse(yearBox.Text), 
                month: Int32.Parse(monthBox.Text),
                day: Int32.Parse(dayBox.Text),
                hour: Int32.Parse(hourBox.Text),
                minute: Int32.Parse(minuteBox.Text),
                second: 0), 
                message: messageBox.Text,  
                person: personBox.Text,
                requirements: requirements);
            foreach (Entry entry in viewEntry.form.entryList)
            {
                for (int i = 0; i < entry.requirements.Value.Count(); i++)
                {
                    if (entry.requirements.Value[i].Equals(viewEntry.form.entryList[viewEntry.selected]))
                    {
                        entry.requirements.Value.Add(newEntry);
                    }
                }
            }
            viewEntry.form.entryList.Add(newEntry);
            viewEntry.form.Reload();
            for (int i=0; i<viewEntry.form.entryList.Count(); i++)
            {
                if (viewEntry.form.entryList[i].Equals(newEntry))
                {
                    viewEntry.selected = i;
                    break;
                }
            }
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

        private void UpdateEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
