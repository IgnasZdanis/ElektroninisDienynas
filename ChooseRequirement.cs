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
    public partial class ChooseRequirement : Form
    {
        CreateEntry createEntry;
        UpdateEntry updateEntry;
        EntryList entryList;
        EntryList requirements;
        EntryList remainingRequirements = new EntryList();
        List<string> stringList;
        List<string> allStringList = new List<string>();
        List<string> dataSource = new List<string>();

        public ChooseRequirement()
        {
            InitializeComponent();
        }
        public ChooseRequirement(CreateEntry createEntry)
        {
            InitializeComponent();
            this.entryList = createEntry.form.entryList;
            this.stringList = createEntry.stringList;
            this.requirements = createEntry.requirements;
            foreach(Entry entry in entryList)
            {
                allStringList.Add(entry.ToString());
            }
            //allStringList = createEntry.form.stringList;
            this.createEntry = createEntry;
            Initialize();
            listBox1.DataSource = null;
            listBox1.DataSource = dataSource;
        }

        public ChooseRequirement(UpdateEntry updateEntry)
        {
            InitializeComponent();
            this.entryList = updateEntry.viewEntry.form.entryList;
            this.stringList = updateEntry.stringList;
            this.requirements = updateEntry.requirements;
            this.updateEntry = updateEntry;
            foreach (Entry entry in entryList)
            {
                allStringList.Add(entry.ToString());
            }
            //allStringList = updateEntry.viewEntry.form.stringList;
            Initialize();
            listBox1.DataSource = null;
            listBox1.DataSource = dataSource;
        }

        public void Initialize()
        {
            foreach (Entry req in entryList)
            {
                bool okToAdd = true;
                if (updateEntry != default(UpdateEntry))
                    if (req.dateTime >= entryList[updateEntry.viewEntry.selected].dateTime)
                        okToAdd = false;
                foreach (Entry req2 in requirements)
                {
                    if (req.Equals(req2)) okToAdd = false;                 
                }
                if (okToAdd) remainingRequirements.Add(req);
            }
            foreach(Entry entry in remainingRequirements)
            {
                dataSource.Add(entry.ToString());
            }
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < allStringList.Count(); i++)
                {
                    if (allStringList[i] == dataSource[listBox1.SelectedIndex])
                    {
                        Entry newRequirement = entryList[i];
                        requirements.Add(newRequirement);
                        stringList.Add(newRequirement.ToString());
                    }
                }
            }
            catch { }   
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
