namespace DatabaseTest
{
    partial class LoginForm
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
            tb_User = new TextBox();
            tb_Pass = new TextBox();
            btn_Login = new Button();
            chkb_Showpassword = new CheckBox();
            ll_Signup = new LinkLabel();
            SuspendLayout();
            // 
            // tb_User
            // 
            tb_User.Location = new Point(195, 67);
            tb_User.Name = "tb_User";
            tb_User.PlaceholderText = "Username";
            tb_User.Size = new Size(100, 23);
            tb_User.TabIndex = 0;
            // 
            // tb_Pass
            // 
            tb_Pass.Location = new Point(195, 122);
            tb_Pass.Name = "tb_Pass";
            tb_Pass.PlaceholderText = "Password";
            tb_Pass.Size = new Size(100, 23);
            tb_Pass.TabIndex = 1;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(208, 169);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(75, 23);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // chkb_Showpassword
            // 
            chkb_Showpassword.AutoSize = true;
            chkb_Showpassword.Location = new Point(204, 235);
            chkb_Showpassword.Name = "chkb_Showpassword";
            chkb_Showpassword.Size = new Size(108, 19);
            chkb_Showpassword.TabIndex = 3;
            chkb_Showpassword.Text = "Show password";
            chkb_Showpassword.UseVisualStyleBackColor = true;
            // 
            // ll_Signup
            // 
            ll_Signup.AutoSize = true;
            ll_Signup.Location = new Point(369, 175);
            ll_Signup.Name = "ll_Signup";
            ll_Signup.Size = new Size(76, 15);
            ll_Signup.TabIndex = 5;
            ll_Signup.TabStop = true;
            ll_Signup.Text = "Sign up here!";
            ll_Signup.LinkClicked += ll_Signup_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 341);
            Controls.Add(ll_Signup);
            Controls.Add(chkb_Showpassword);
            Controls.Add(btn_Login);
            Controls.Add(tb_Pass);
            Controls.Add(tb_User);
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_User;
        private TextBox tb_Pass;
        private Button btn_Login;
        private CheckBox chkb_Showpassword;
        private LinkLabel ll_Signup;
    }
}