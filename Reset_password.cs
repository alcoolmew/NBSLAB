using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Net.Mime.MediaTypeNames;


namespace LoginScreen
{
    public partial class Reset_password : Form
    {
        string username = Varifaction_Screen.to;


        public Reset_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\Desktop\\projeler\\LoginScreen\\UserInformation.mdf;Integrated Security=True")) ;
                using (SqlCommand cmd = new SqlCommand("USE [UserInformation]\r\nGO\r\n\r\nUPDATE [dbo].[Registration]\r\n   SET [Password] = '" + textBox2.Text + "',>\r\n WHERE username='" + username + "' <Search Conditions,,>\r\nGO\r\n\r\n\r\n,conn")) ;
                ;
                MessageBox.Show("Your Password Has been Changed");

                Form1 f = new Form1();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Passwords are do not match,Please enter same password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
