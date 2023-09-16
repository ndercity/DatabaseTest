namespace DatabaseTest
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_Firstname = new TextBox();
            tb_Lastname = new TextBox();
            tb_Email = new TextBox();
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            cb_Gender = new ComboBox();
            dtp_Birthday = new DateTimePicker();
            btn_Next1 = new Button();
            btn_Back1 = new Button();
            btn_Next2 = new Button();
            btn_Back2 = new Button();
            btn_Next3 = new Button();
            tb_Confirm = new TextBox();
            SuspendLayout();
            // 
            // tb_Firstname
            // 
            tb_Firstname.Location = new Point(98, 27);
            tb_Firstname.Name = "tb_Firstname";
            tb_Firstname.PlaceholderText = "First Name";
            tb_Firstname.Size = new Size(100, 23);
            tb_Firstname.TabIndex = 0;
            // 
            // tb_Lastname
            // 
            tb_Lastname.Location = new Point(98, 56);
            tb_Lastname.Name = "tb_Lastname";
            tb_Lastname.PlaceholderText = "Last name";
            tb_Lastname.Size = new Size(100, 23);
            tb_Lastname.TabIndex = 1;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(98, 184);
            tb_Email.Name = "tb_Email";
            tb_Email.PlaceholderText = "Email";
            tb_Email.Size = new Size(100, 23);
            tb_Email.TabIndex = 2;
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(98, 213);
            tb_Username.Name = "tb_Username";
            tb_Username.PlaceholderText = "Username";
            tb_Username.Size = new Size(100, 23);
            tb_Username.TabIndex = 3;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(98, 246);
            tb_Password.Name = "tb_Password";
            tb_Password.PlaceholderText = "Password";
            tb_Password.Size = new Size(100, 23);
            tb_Password.TabIndex = 4;
            // 
            // cb_Gender
            // 
            cb_Gender.FormattingEnabled = true;
            cb_Gender.Location = new Point(266, 56);
            cb_Gender.Name = "cb_Gender";
            cb_Gender.Size = new Size(121, 23);
            cb_Gender.TabIndex = 5;
            // 
            // dtp_Birthday
            // 
            dtp_Birthday.Location = new Point(266, 27);
            dtp_Birthday.Name = "dtp_Birthday";
            dtp_Birthday.Size = new Size(200, 23);
            dtp_Birthday.TabIndex = 6;
            // 
            // btn_Next1
            // 
            btn_Next1.Location = new Point(416, 155);
            btn_Next1.Name = "btn_Next1";
            btn_Next1.Size = new Size(75, 23);
            btn_Next1.TabIndex = 7;
            btn_Next1.Text = "button1";
            btn_Next1.UseVisualStyleBackColor = true;
            btn_Next1.Click += btn_Next1_Click;
            // 
            // btn_Back1
            // 
            btn_Back1.Location = new Point(335, 184);
            btn_Back1.Name = "btn_Back1";
            btn_Back1.Size = new Size(75, 23);
            btn_Back1.TabIndex = 8;
            btn_Back1.Text = "button2";
            btn_Back1.UseVisualStyleBackColor = true;
            btn_Back1.Click += btn_Back1_Click;
            // 
            // btn_Next2
            // 
            btn_Next2.Location = new Point(416, 184);
            btn_Next2.Name = "btn_Next2";
            btn_Next2.Size = new Size(75, 23);
            btn_Next2.TabIndex = 9;
            btn_Next2.Text = "button3";
            btn_Next2.UseVisualStyleBackColor = true;
            btn_Next2.Click += btn_Next2_Click;
            // 
            // btn_Back2
            // 
            btn_Back2.Location = new Point(335, 213);
            btn_Back2.Name = "btn_Back2";
            btn_Back2.Size = new Size(75, 23);
            btn_Back2.TabIndex = 10;
            btn_Back2.Text = "button4";
            btn_Back2.UseVisualStyleBackColor = true;
            btn_Back2.Click += btn_Back2_Click;
            // 
            // btn_Next3
            // 
            btn_Next3.Location = new Point(416, 213);
            btn_Next3.Name = "btn_Next3";
            btn_Next3.Size = new Size(75, 23);
            btn_Next3.TabIndex = 11;
            btn_Next3.Text = "button5";
            btn_Next3.UseVisualStyleBackColor = true;
            btn_Next3.Click += btn_Next3_Click;
            // 
            // tb_Confirm
            // 
            tb_Confirm.Location = new Point(98, 275);
            tb_Confirm.Name = "tb_Confirm";
            tb_Confirm.PlaceholderText = "Confirm Password";
            tb_Confirm.Size = new Size(100, 23);
            tb_Confirm.TabIndex = 12;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 341);
            Controls.Add(tb_Confirm);
            Controls.Add(btn_Next3);
            Controls.Add(btn_Back2);
            Controls.Add(btn_Next2);
            Controls.Add(btn_Back1);
            Controls.Add(btn_Next1);
            Controls.Add(dtp_Birthday);
            Controls.Add(cb_Gender);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(tb_Email);
            Controls.Add(tb_Lastname);
            Controls.Add(tb_Firstname);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Firstname;
        private TextBox tb_Lastname;
        private TextBox tb_Email;
        private TextBox tb_Username;
        private TextBox tb_Password;
        private ComboBox cb_Gender;
        private DateTimePicker dtp_Birthday;
        private Button btn_Next1;
        private Button btn_Back1;
        private Button btn_Next2;
        private Button btn_Back2;
        private Button btn_Next3;
        private TextBox tb_Confirm;
    }
}