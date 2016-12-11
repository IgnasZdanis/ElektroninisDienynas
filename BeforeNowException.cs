using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektroninisDienynas
{
    [Serializable]
    public class BeforeNowException : Exception
    {
        public BeforeNowException() : base()
        {

        }

        public BeforeNowException(string message) : base(message)
        {

        }


    }
}
