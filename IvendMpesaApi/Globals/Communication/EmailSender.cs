using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace smcaptureLib.Globals.Communication
{
    //send the email address to user

    public class EmailSender
    {

        public MailMessage MyMailMessage { get; set; }
        #region Configuration
        NetworkCredential mailAuthentication = new NetworkCredential(Configuration.SMSSubsystemEmailAdress, Configuration.SMSSubsystemPassWord);

        SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
        public string EmailAdress { get; private set; }
        public string PassWord { get; private set; }
        #endregion
        public EmailSender()
        {
            MyMailMessage = new MailMessage();
            EmailAdress = Configuration.SMSSubsystemEmailAdress;
            PassWord = Configuration.SMSSubsystemPassWord;
        }

        public EmailSender(string emailAdress, string emailPassword)
        {
            EmailAdress = emailAdress;
            PassWord = emailPassword;
            mailAuthentication = new NetworkCredential(EmailAdress, PassWord);
        }
        public void SetMessageContent(string Subject, string MessageBody)
        {
            MyMailMessage.Subject = Subject;
            MyMailMessage.Subject += string.Format("Date: {0}", DateTime.Now.ToLongDateString());
            MyMailMessage.IsBodyHtml = false;
            MyMailMessage.Body = MessageBody;
        }

        public void SetRecipient(string RecipientAdress)
        {
            MyMailMessage.To.Add(new MailAddress(RecipientAdress));
        }

        public void SetMessageFrom(string SenderAdress)
        {
            MyMailMessage.From = new MailAddress(SenderAdress);
        }

        public void SendEmail()
        {
            try
            {
                //Enable SSL
                mailClient.EnableSsl = true;
                mailClient.UseDefaultCredentials = false;
                mailClient.Credentials = mailAuthentication;
                mailClient.Send(MyMailMessage);
            }

            catch (System.Threading.ThreadAbortException)
            {

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}