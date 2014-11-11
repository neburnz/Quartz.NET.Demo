using MailClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class MailServiceTest
    {
        [TestMethod]
        public void SendEmailStringTest()
        {
            MailService target = new MailService();

            string from = "kantan.test.mail@gmail.com";
            string to = "kantan.test.user@gmail.com";
            string subject = "INFORMATION: SendEmailStringTest";
            string body = "SendEmailStringTest body";

            bool result = target.SendEmail(from, to, subject, body);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SendEmailMessageTest()
        {
            MailService target = new MailService();
            MailMessage message = new MailMessage("kantan.test.mail@gmail.com", "kantan.test.user@gmail.com", "INFORMATION: SendEmailMessageTest", "SendEmailMessageTest body");

            bool result = target.SendEmail(message);

            Assert.IsTrue(result);
        }
    }
}
