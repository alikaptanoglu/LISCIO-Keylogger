using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace LISCIO
{
    public partial class testMail : UserControl
    {
        public testMail()
        {
            InitializeComponent();
       
        }

        private void _testBtn_Click(object sender, EventArgs e)
        {

            if (_mailTxt.Text !="" && _passTxt.Text !="" && _mailTxt.Text.Contains('@'))
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential(_mailTxt.Text, _passTxt.Text);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(_mailTxt.Text, "LISCIO");
                mail.To.Add(_mailTxt.Text);
                mail.Subject = "Success!!!"; mail.IsBodyHtml = true; mail.Body = "LISCIO has done its job!!! ;)";
                sc.Send(mail);
                MessageBox.Show("Submission completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!_mailTxt.Text.Contains("@"))
            {
                MessageBox.Show("Mail format is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Check the entries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
