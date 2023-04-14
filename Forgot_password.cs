using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LoginScreen
{
    public partial class Varifaction_Screen : Form
    {
        string randomCode;
        public static string to;

        public Varifaction_Screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messegeBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (textBox3.Text).ToString();
            from = "gurkanalikapsizlar@gmail.com";
            pass = "ftazqzixcxwgmcju";
            messegeBody = "Your Reset Code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messegeBody;
            message.Subject = "Your Varification Code for Reseting Your Password";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try

            {
                smtp.Send(message);
                MessageBox.Show("Your varifaction Code Sended");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (textBox2.Text).ToString())
            {
                to = textBox3.Text;
                Reset_password rp = new Reset_password();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Entered valid Numbers, Please try Again");

            }
        }
    }
}
