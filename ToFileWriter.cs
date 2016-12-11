using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektroninisDienynas
{
    public class ToFileWriter : ITextStream
    {
        public void write(List<string> stringList)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(fileDialog.FileName, string.Join(System.Environment.NewLine, stringList));
            }
        }
    }
}
