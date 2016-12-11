using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektroninisDienynas
{
    public class EntryListChangedEventArgs     
    {
        public Entry newEntry;
        public EntryListChangedEventArgs(Entry entry)
        {
            this.newEntry = entry;
        }
    }
}
