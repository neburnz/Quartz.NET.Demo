namespace MailClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Mail;
    using System.Text;
    using System.Threading.Tasks;

    public class MailService
    {
        public MailService()
        {

        }

        public bool SendEmail(MailMessage message)
        {
            bool result = false;

            try
            {
                SmtpClient client = new SmtpClient();

                client.Send(message);

                result = true;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("InvalidOperationException: {0} -> {1}", ex.Message, ex.StackTrace.ToString());
            }
            catch (SmtpFailedRecipientException ex)
            {
                Console.WriteLine("SmtpFailedRecipientException: {0} -> {1}", ex.Message, ex.StackTrace.ToString());
            }
            catch (SmtpException ex)
            {
                Console.WriteLine("SmtpException: {0} -> {1}", ex.Message, ex.StackTrace.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0} -> {1}", ex.Message, ex.StackTrace.ToString());
            }

            return result;
        }

        public bool SendEmail(string from, string to, string subject, string body)
        {
            bool result = false;

            MailMessage message = new MailMessage(from, to, subject, body);

            result = SendEmail(message);

            return result;
        }
    }
}
