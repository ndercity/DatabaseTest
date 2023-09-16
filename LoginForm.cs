using MySql.Data.MySqlClient;

namespace DatabaseTest
{
    public partial class LoginForm : Form
    {
        RegistrationForm regform = new RegistrationForm();
        public static LoginForm instance;
        private MySqlConnection conn;
        public LoginForm()
        {
            InitializeComponent();
            instance = this;
            string mysqlconn = "server=localhost;user=root;database=databasetest;password=";
            conn = new MySqlConnection(mysqlconn);

            try
            {
                conn.Open();
                MessageBox.Show("Connection Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
        }

        private void ll_Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regform.Show();
        }
    }
}