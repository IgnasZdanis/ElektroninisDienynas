using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektroninisDienynas
{
    public class TextStream
    {
        ITextStream stream;
        public TextStream(ITextStream stream)
        {
            this.stream = stream;
        }

        public void write(List<string> stringList)
        {
            stream.write(stringList);
        }
    }
}
