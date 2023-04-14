namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            CloseButton = new Button();
            label5 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            OR = new Label();
            Panel_registration = new Button();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            label6 = new Label();
            panel_forget_password = new Button();
            panel_login = new Button();
            panel6 = new Panel();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 707);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(349, 355);
            panel5.Name = "panel5";
            panel5.Size = new Size(507, 45);
            panel5.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(339, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(518, 56);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(232, 641);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 4;
            label4.Text = "NBS LAB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(232, 613);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 3;
            label3.Text = "Developed By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(163, 375);
            label2.Name = "label2";
            label2.Size = new Size(136, 41);
            label2.TabIndex = 0;
            label2.Text = "NBS LAB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 317);
            label1.Name = "label1";
            label1.Size = new Size(269, 41);
            label1.TabIndex = 1;
            label1.Text = "WELCOME TO THE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.Location = new Point(811, 0);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(46, 53);
            CloseButton.TabIndex = 7;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(429, 80);
            label5.Name = "label5";
            label5.Size = new Size(316, 41);
            label5.TabIndex = 2;
            label5.Text = "Log in to your account";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(343, 244);
            panel4.Name = "panel4";
            panel4.Size = new Size(514, 60);
            panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.Hand;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(58, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(411, 21);
            textBox1.TabIndex = 0;
            textBox1.Click += textBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(OR);
            panel2.Controls.Add(Panel_registration);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel_forget_password);
            panel2.Controls.Add(panel_login);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(CloseButton);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.ForeColor = Color.Silver;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(857, 707);
            panel2.TabIndex = 0;
            // 
            // OR
            // 
            OR.AutoSize = true;
            OR.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            OR.ForeColor = Color.Black;
            OR.Location = new Point(555, 491);
            OR.Name = "OR";
            OR.Size = new Size(37, 25);
            OR.TabIndex = 2;
            OR.Text = "OR";
            // 
            // Panel_registration
            // 
            Panel_registration.BackColor = Color.Black;
            Panel_registration.FlatStyle = FlatStyle.Flat;
            Panel_registration.ForeColor = Color.White;
            Panel_registration.Location = new Point(501, 528);
            Panel_registration.Name = "Panel_registration";
            Panel_registration.Size = new Size(166, 45);
            Panel_registration.TabIndex = 4;
            Panel_registration.Text = "Create a Account";
            Panel_registration.UseVisualStyleBackColor = false;
            Panel_registration.Click += button3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.Silver;
            linkLabel1.LinkColor = Color.Silver;
            linkLabel1.Location = new Point(391, 653);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(155, 19);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "example@gmail.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(389, 632);
            label7.Name = "label7";
            label7.Size = new Size(119, 19);
            label7.TabIndex = 5;
            label7.Text = "+90 xxx xxx xxx";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(389, 613);
            label6.Name = "label6";
            label6.Size = new Size(89, 19);
            label6.TabIndex = 4;
            label6.Text = "For Support ";
            // 
            // panel_forget_password
            // 
            panel_forget_password.BackColor = Color.White;
            panel_forget_password.Cursor = Cursors.Hand;
            panel_forget_password.FlatAppearance.BorderSize = 0;
            panel_forget_password.FlatStyle = FlatStyle.Flat;
            panel_forget_password.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel_forget_password.ForeColor = Color.Black;
            panel_forget_password.Location = new Point(624, 431);
            panel_forget_password.Name = "panel_forget_password";
            panel_forget_password.Size = new Size(189, 45);
            panel_forget_password.TabIndex = 3;
            panel_forget_password.Text = "Forget  Password?";
            panel_forget_password.UseVisualStyleBackColor = false;
            panel_forget_password.Click += panel_forget_password_Click;
            // 
            // panel_login
            // 
            panel_login.BackColor = Color.Black;
            panel_login.Cursor = Cursors.Hand;
            panel_login.FlatAppearance.BorderSize = 0;
            panel_login.FlatStyle = FlatStyle.Flat;
            panel_login.ForeColor = Color.White;
            panel_login.Location = new Point(391, 430);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(145, 45);
            panel_login.TabIndex = 2;
            panel_login.Text = "LOGIN";
            panel_login.UseVisualStyleBackColor = false;
            panel_login.Click += button1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(textBox2);
            panel6.Controls.Add(pictureBox3);
            panel6.Location = new Point(343, 309);
            panel6.Name = "panel6";
            panel6.Size = new Size(514, 60);
            panel6.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.Hand;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(58, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(411, 21);
            textBox2.TabIndex = 0;
            textBox2.UseSystemPasswordChar = true;
            textBox2.Click += textBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 8);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown_1;
            pictureBox3.MouseUp += pictureBox3_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(857, 707);
            ControlBox = false;
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "1";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button CloseButton;
        private Label label5;
        private Panel panel4;
        private Panel panel2;
        private Button panel_forget_password;
        private Button panel_login;
        private LinkLabel linkLabel1;
        private Label label7;
        private Label label6;
        private Panel panel6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label OR;
        private Button Panel_registration;
        private TextBox textBox2;
    }
}