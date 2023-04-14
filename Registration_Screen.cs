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
using LoginScreen;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;





namespace LoginScreen
{
    public partial class Registration_Screen : Form
    {
        string RandomCode;
        public static string to;
        private const bool V = true;

        private List<TextBox> textBoxes;

        public Registration_Screen()
        {
            InitializeComponent();
            textBoxes = new List<TextBox> { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };

            // Add click event handler to each textbox
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Click += TextBox_Click;
                textBox1.TabStop = V;
                textBox1.TabIndex = 0;

                textBox2.TabStop = V;
                textBox2.TabIndex = 1;

                textBox3.TabStop = V;
                textBox3.TabIndex = 2;

                textBox4.TabStop = V;
                textBox4.TabIndex = 3;

                textBox5.TabStop = V;
                textBox5.TabIndex = 4;

                textBox6.TabStop = V;
                textBox6.TabIndex = 5;

                textBox7.TabStop = V;
                textBox7.TabIndex = 6;

                button1.TabStop = V;
                button1.TabIndex = 7;

                button2.TabStop = V;
                button2.TabIndex = 8;

                button3.TabStop = V;
                button3.TabIndex = 9;
            }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            // Change backcolor of parent panel of clicked textbox to white, and all other parent panels to control
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox == sender)
                {
                    textBox.Parent.BackColor = Color.White;
                    textBox.BackColor = Color.White;
                }
                else
                {
                    textBox.Parent.BackColor = Color.FromKnownColor(KnownColor.Control);
                    textBox.BackColor = Color.FromKnownColor(KnownColor.Control);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Define your SQL Connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gürkan\Desktop\projeler\LoginScreen\UserInformation.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Check if Names and Surnames contain any numbers or symbols
                    if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("Numbers are not allowed in Names.");
                        return;
                    }
                    if (!string.IsNullOrEmpty(textBox2.Text) && textBox2.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("Numbers are not allowed in Surnames.");
                        return;
                    }

                    // Check if Username contains any symbols
                    if (!string.IsNullOrEmpty(textBox5.Text) && textBox5.Text.Any(c => !char.IsLetterOrDigit(c)))
                    {
                        MessageBox.Show("Symbols are not allowed in Username.");
                        return;
                    }

                    // Create a SQL command to insert data into the table
                    SqlCommand command = new SqlCommand("INSERT INTO Registration (Names, Surnames, Email, Username, Password) VALUES (@Names, @Surnames, @Mail, @Username, @Password)", connection);

                    if (textBox3.Text != textBox4.Text)
                    {
                        MessageBox.Show("The email confirmation does not match the email.");
                        return;
                    }
                    if (textBox6.Text != textBox7.Text)
                    {
                        MessageBox.Show("The password confirmation does not match the password.");
                        return;
                    }

                    // Add parameter values for each textbox value
                    command.Parameters.AddWithValue("@Names", textBox1.Text);
                    command.Parameters.AddWithValue("@Surnames", textBox2.Text);
                    command.Parameters.AddWithValue("@Mail", textBox3.Text);
                    command.Parameters.AddWithValue("@Username", textBox5.Text);
                    command.Parameters.AddWithValue("@Password", textBox6.Text);


                    // Execute the SQL command
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");



                        Form1 loginForm = new Form1();
                        this.Hide();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            Form1 loginForm = new Form1();
            this.Hide();
            loginForm.Show();


        }

        private void sd(object sender, EventArgs e)
        {

        }
    }
}
