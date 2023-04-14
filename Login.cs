using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Net.Mail;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        private const bool V = true;

        public Form1()
        {

            InitializeComponent();

            textBox1.TabStop = V;
            textBox1.TabIndex = 0;

            textBox2.TabStop = V;
            textBox2.TabIndex = 1;

            panel_login.TabStop = V;
            panel_login.TabIndex = 2;

            panel_forget_password.TabStop = V;
            panel_forget_password.TabIndex = 3;

            Panel_registration.TabStop = V;
            Panel_registration.TabIndex = 4;

            CloseButton.TabStop = V;
            CloseButton.TabIndex = 5;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel6.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel6.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown_1(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = V;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Registration_Screen regForm = new Registration_Screen();
            regForm.Show();
            // Close the login form
            this.Hide();

            // Show the registration form
            regForm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Gürkan\\Desktop\\projeler\\LoginScreen\\UserInformation.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Registration WHERE username=@username AND password=@password", conn);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfully");
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }

        }

        private void panel_forget_password_Click(object sender, EventArgs e)
        {


            Varifaction_Screen sc = new Varifaction_Screen();
            this.Hide();
            sc.Show();
        }
    }
}
