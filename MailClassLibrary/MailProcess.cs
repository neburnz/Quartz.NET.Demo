using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClassLibrary
{
    public class MailProcess
    {
        public MailProcess()
        {

        }

        public void DoWork()
        {
            MailService service = new MailService();

            string from = "kantan.test.mail@gmail.com";
            string to = "kantan.test.user@gmail.com";
            string subject = "INFORMATION: Executed task";
            string body = string.Format("The current time is {0}", DateTime.Now);

            service.SendEmail(from, to, subject, body);
        }
    }
}
