using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay1
{
    internal class User
    {
        private string email;
        private string password;

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }



    public class UserService
    {
        EmailService emailService = new EmailService();

        public void Register(string email, string password)
        {
            if (!emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new User(email, password);

            emailService.SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
        }

    }

    public class EmailService
    {

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public bool SendEmail(MailMessage message)
        {
            
            SmtpClient _smtpClient=new SmtpClient();
            _smtpClient.Send(message);
            return true;
        }
    }


}
