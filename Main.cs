using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektroninisDienynas
{
    public partial class Main : Form
    {
        public EntryList entryList = new EntryList();     
        public List<string> dataSource = new List<string>();
        public bool show = false;

        public Main()
        {
            InitializeComponent();

            load();           
            entryList.Sort();
            Reload();
            comboBox.Items.Add("Save to file");
            comboBox.Items.Add("Send email");

            monthCalendar1.BoldedDates = BoldDates(entryList);
            DateTime now = DateTime.Now;
            bool foundOne = false;
            for (int i = 0; i < entryList.Count(); i++)
            {
                if (entryList[i].dateTime < now)
                {
                    foundOne = true;
                    DeadlineForm deadlineForm = new DeadlineForm(this, entryList[i], i);
                    //this.WindowState = FormWindowState.Minimized;
                    //this.ShowInTaskbar = false;
                    deadlineForm.Visible = true;
                    break;
                }
            }
            if (!foundOne)
            {
                show = true;
                Visible = true;
            }
            
        }

        public Func<EntryList, DateTime[]> BoldDates = delegate (EntryList entryList)
        {
            List<DateTime> toBoldDates = new List<DateTime>();
            foreach (Entry entry in entryList)
            {
                toBoldDates.Add(new DateTime(entry.dateTime.Year, entry.dateTime.Month, entry.dateTime.Day));
            }
            return toBoldDates.ToArray();
        };

        public void EntryListChangedHandler(CreateEntry sender, EntryListChangedEventArgs e)
        {
            entryList.Add(sender.newEntry);
            monthCalendar1.BoldedDates = BoldDates(entryList);
            Reload();        
        }

        public void GetFromInternet(string website)
        {
            List<string> lectures = new List<string>();
            List<string> employees = new List<string>();
            List<string> dates = new List<string>();
            List<string> times = new List<string>();
            List<string> rooms = new List<string>();
            WebClient client = new WebClient();
            
            String html = client.DownloadString(website);
            MatchCollection subjectsCollection = Regex.Matches(html, @"subjects/(.+?)/", RegexOptions.Singleline);
            MatchCollection employeeCollection = Regex.Matches(html, @"employees/(.+?)/..>(.+?)<", RegexOptions.Singleline);
            MatchCollection roomCollection = Regex.Matches(html, @"rooms/(.+?)/..>(.+?)<", RegexOptions.Singleline);
            MatchCollection dateCollection = Regex.Matches(html, @"start.:\s*.(.+?)T(.+?).,", RegexOptions.Singleline);
            foreach (Match m in subjectsCollection)
            {
                string lecture = m.Groups[1].Value;
                lectures.Add(lecture);             
            }
            foreach(Match m in dateCollection)
            {
                string date = m.Groups[1].Value;
                string time = m.Groups[2].Value;
                dates.Add(date);
                times.Add(time);
            }
            foreach(Match m in employeeCollection)
            {
                string employee = m.Groups[2].Value;
                employees.Add(employee);
            }
            foreach (Match m in roomCollection)
            {
                string room = m.Groups[2].Value;
                rooms.Add(room);
            }
            lectures.RemoveAt(0);
            dates.RemoveAt(dates.Count() - 1);
            dates.RemoveAt(dates.Count() - 1);
            times.RemoveAt(times.Count() - 1);
            times.RemoveAt(times.Count() - 1);
            employees.RemoveAt(0);
            rooms.RemoveAt(0);
            for (int i=0; i<employees.Count(); i++)
            {
                string[] ymd = dates[i].Split('-');
                string[] hms = times[i].Split(':');
                DateTime dateTime = new DateTime(
                    Int32.Parse(ymd[0]),
                    Int32.Parse(ymd[1]),
                    Int32.Parse(ymd[2]),
                    Int32.Parse(hms[0]),
                    Int32.Parse(hms[1]),
                    0);
                DateTime now = DateTime.Now;
                if (dateTime > now)
                {
                    Entry newEntry = new Entry(
                    dateTime,
                    lectures[i] + " " + rooms[i],
                    employees[i]);
                    bool okToAdd = true;
                    foreach(Entry entry in entryList)
                    {
                        if (entry.Equals(newEntry)) okToAdd = false;
                    }
                    if (okToAdd)
                        entryList.Add(newEntry);
                }                 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void save()
        {
            string dir = @"C:\Users\Ignas\Documents\Visual Studio 2015\Projects\ElektroninisDienynas\ElektroninisDienynas";
            string serializationFile = Path.Combine(dir, "entry.bin");
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, entryList);
            }
            
        }

        protected override void SetVisibleCore(bool value)
        {
            // Quick and dirty to keep the main window invisible
            // you can put some logic here to decide when to use the
            // incomming value and when to force it to be false as I 
            // am showing here.       
            base.SetVisibleCore(value && show);
        }

        public void load()
        {
            string dir = @"C:\Users\Ignas\Documents\Visual Studio 2015\Projects\ElektroninisDienynas\ElektroninisDienynas";
            string serializationFile = Path.Combine(dir, "entry.bin");
            try
            {
                using (Stream stream = File.Open(serializationFile, FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    entryList = (EntryList)bformatter.Deserialize(stream);
                }
            }
            catch 
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save();
        }

        private void createButton_Click(object sender, EventArgs e)
        {        
            CreateEntry createEntry = new CreateEntry(this);
            createEntry.Visible = true;
            Visible = false;
            createEntry.EntryListChanged += EntryListChangedHandler;
            createEntry.FormClosing += CreateEntryFormClosingHandler;
        }

        private void CreateEntryFormClosingHandler(object sender, FormClosingEventArgs e)
        {
            Visible = true;
        }

        public void Reload()
        {
            entryList.Sort();
            dataSource = new List<string>();
            listBox2.DataSource = null;
            foreach (Entry entry in entryList)
            {
                if (entry.dateTime.Year == monthCalendar1.SelectionStart.Year &&
                    entry.dateTime.Month == monthCalendar1.SelectionStart.Month &&
                    entry.dateTime.Day == monthCalendar1.SelectionStart.Day
                    )
                {
                    dataSource.Add(entry.ToString());
                }
            }
            listBox2.DataSource = dataSource;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataSource.Count() != 0 && listBox2.Items.Count != 0)
            {
                int selected = 0;
                for (int i = 0; i < entryList.Count(); i++)
                {
                    if (dataSource[listBox2.SelectedIndex] == entryList[i].ToString())
                    {
                        selected = i;
                        break;
                    }
                }
                foreach (Entry entry in entryList)
                {
                    for (int i = 0; i < entry.requirements.Value.Count(); i++)
                    {
                        if (entryList[selected].Equals(entry.requirements.Value[i]))
                        {
                            entry.requirements.Value.RemoveAt(i);
                        }
                    }
                }
                entryList.RemoveAt(selected);
                monthCalendar1.BoldedDates = BoldDates(entryList);
                Reload();
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (dataSource.Count() != 0 && listBox2.Items.Count != 0)
            {
                ViewEntry viewEntry = new ViewEntry(this);
                viewEntry.Visible = true;
                Visible = false;
            }
        }

        public void forDeadlineForm(int index)
        {
            ViewEntry viewEntry = new ViewEntry(this, index);
            UpdateEntry updateEntry = new UpdateEntry(viewEntry);
            Visible = false;
            updateEntry.Visible = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<string> stringList = new List<string>();
            dataSource.Clear();
            foreach (var entry in entryList)
            {
                stringList.Add(entry.ToString());
            }
            var searchResult = from i in stringList where
                                Regex.IsMatch(i, searchBox.Text, RegexOptions.IgnoreCase)
                                select i;
            foreach(string data in searchResult)
            {
                dataSource.Add(data);
            }
            listBox2.DataSource = null;
            listBox2.DataSource = dataSource;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to save?", "Do you want to save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                save();
            }
        }

        private void internetButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => internetButtonFunction());
            thread.Start();
        }

        public void internetButtonFunction()
        {
            lock (entryList)
            {
                try
                {
                    string website = internetBox.Text;
                    GetFromInternet(website);
                    MessageBox.Show("Data succesfuly read", "Message", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Wrong website", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataSource = new List<string>();
            listBox2.DataSource = null;
            
            foreach (Entry entry in entryList)
            {
                if (entry.dateTime.Year == monthCalendar1.SelectionStart.Year &&
                    entry.dateTime.Month == monthCalendar1.SelectionStart.Month &&
                    entry.dateTime.Day == monthCalendar1.SelectionStart.Day
                    )
                {
                    dataSource.Add(entry.ToString());
                }
            }
            listBox2.DataSource = dataSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entryList.Sort();
            Reload();
        }

        private void saveToButton_Click(object sender, EventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    {
                        ToFileWriter fileWriter = new ToFileWriter();
                        TextStream textStream = new TextStream(fileWriter);
                        textStream.write(dataSource);
                        break;
                    }
                case 1:
                    {
                        Thread thread = new Thread(() =>
                       {
                           EmailWriter emailWriter = new EmailWriter();
                           TextStream textStream = new TextStream(emailWriter);
                           textStream.write(dataSource);
                       });
                        thread.Start();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            

        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            //float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1280;
            //float heightRatio = Screen.PrimaryScreen.Bounds.Height / 800f;
            //SizeF scale = new SizeF(widthRatio, heightRatio);
            //this.Scale(scale);
            //foreach (Control control in this.Controls)
            //{
            //    control.Font = new Font("Verdana", control.Font.SizeInPoints * heightRatio * widthRatio);
            //}
        }
    }
}
