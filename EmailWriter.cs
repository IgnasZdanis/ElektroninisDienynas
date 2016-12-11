using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ElektroninisDienynas
{
    public class EmailWriter : ITextStream
    {
        public void write(List<string> stringList)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("zdanis.ignas@gmail.com", "m00fin55"),
                EnableSsl = true
            };
            client.Send("zdanis.ignas@gmail.com", "zdanis.ignas@gmail.com", "Your desired events", string.Join(System.Environment.NewLine, stringList));
        }
    }
}
