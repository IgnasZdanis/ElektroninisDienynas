using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektroninisDienynas
{
    [Serializable]
    public class EntryList : IEnumerable
    {
        List<Entry> entryList = null;

        public EntryList()
        {
            entryList = new List<Entry>();
        }

        public Entry this [int index]
        {
            get
            {
                try
                {
                    return entryList[index];
                }
                catch
                {
                    return new Entry();
                }
            }
            set
            {
                entryList[index] = value;
            }
        }

        public void Add(Entry entry)
        {
            entryList.Add(entry);
        }

        public void Clear()
        {
            entryList.Clear();
        }

        public int Count()
        {
            return entryList.Count();
        }

        public void RemoveAt(int index)
        {
            try
            {
                entryList.RemoveAt(index);
            }
            catch { }
        }

        public void Sort()
        {
            entryList.Sort();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (object o in entryList)
            {
                if (o == null)
                {
                    break;
                }
                yield return o;
            }
        }

    }
}