using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using BCrypt.Net;
using System.Net.Http.Headers;
using LoginLogupPage;

namespace Password_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Clearlogup()
        {

            textBoxloguppassword.Clear();
            textBoxlogupusername.Clear();
        }
        private void Clearlogin()
        {
            textBoxloginpassword.Clear();
            textBoxloginusername.Clear();
        }
        private void buttonshowlogin_Click(object sender, EventArgs e)
        {
            buttonshowlogin.Visible = false;
            groupBoxlogup.Visible = false;
            groupBoxlogin.Visible = true;
            buttonshowlogup.Visible = true;
            labelsuccess.Visible = false;
            labelunsuccess.Visible = false;
            labelunsuccess1.Visible = false;
            labelusernametaken.Visible = false;
        }
        private void buttonshowlogup_Click(object sender, EventArgs e)
        {
            buttonshowlogup.Visible = false;
            groupBoxlogin.Visible = false;
            groupBoxlogup.Visible = true;
            buttonshowlogin.Visible = true;
            labelloginsuccess.Visible = false;
        }
        SqlConnection connection = new SqlConnection("Data Source=izofat\\SQLEXPRESS;Initial Catalog=users;Integrated Security=True");      //this is my database you should connect yours to work
        int k = 0;
        private void buttonshow_Click(object sender, EventArgs e)
        {
            k++;
            if (k % 2 == 0)
            {
                textBoxloguppassword.UseSystemPasswordChar = true;
                buttonshow.Image = Image.FromFile("C:\\Users\\gorke\\OneDrive\\Documents\\Screenshot 2023-07-31 002212.png");

            }
            else
            {
                textBoxloguppassword.UseSystemPasswordChar = false;
                buttonshow.Image = Image.FromFile("C:\\Users\\gorke\\OneDrive\\Documents\\Screenshot 2023-07-31 133844.png");           // this is my path i added the images in  github repositories
            }
        }
        int m = 0;
        private void buttonshow1_Click(object sender, EventArgs e)
        {
            m++;
            if (m % 2 == 0)
            {
                textBoxloginpassword.UseSystemPasswordChar = true;
                buttonshow1.Image = Image.FromFile("C:\\Users\\gorke\\OneDrive\\Documents\\Screenshot 2023-07-31 002212.png");  
            }
            else
            {
                textBoxloginpassword.UseSystemPasswordChar = false;
                buttonshow1.Image = Image.FromFile("C:\\Users\\gorke\\OneDrive\\Documents\\Screenshot 2023-07-31 133844.png");
            }
        }
        int maxid;
        private void GetMaxID()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select MAX(ID) from UserInfo", connection);       // ........UserInfo....... you should write the table name in your database you are currently working on
            object result = command.ExecuteScalar();
            if (result == DBNull.Value)
            {
                maxid = 0;
            }
            else
            {
                maxid = int.Parse(result.ToString());
            }
            connection.Close();
        }
        private void LogUp()
        {
            string password = textBoxloguppassword.Text.ToString();
            string username = textBoxlogupusername.Text.ToString();
            labelsuccess.Visible = true;
            labelunsuccess.Visible = false;
            labelunsuccess1.Visible = false;
            if (password.Any(char.IsDigit) == true && password.Any(char.IsLetter) == true && password.Length >= 6)
            {
                DataEncryption(username, password);
            }
            else if (password.Any(char.IsDigit) == false && password.Length >= 6 && password.Any(char.IsLetter) == true)
            {
                labelsuccess.Text = "Password must contain at least 1 number !";
            }
            else if (password.Any(char.IsDigit) == true && password.Length < 6 && password.Any(char.IsLetter) == true)
            {
                labelsuccess.Text = "Password length must be at least 6 character !";
            }
            else if (password.Any(char.IsDigit) == true && password.Length >= 6 && password.Any(char.IsLetter) == false)
            {
                labelsuccess.Text = "Password must contain at least 1 letter !";
            }
            else if (password.Any(char.IsDigit) == true && password.Length < 6 && password.Any(char.IsLetter) == false)
            {
                labelsuccess.Text = "Password length must be at least 6 character !";
                labelunsuccess.Visible = true;
                labelunsuccess.Text = "Password must contain at least 1 letter !";
            }
            else if (password.Any(char.IsDigit) == false && password.Length >= 6 && password.Any(char.IsLetter) == false)
            {
                labelsuccess.Text = "Password must contain at least 1 number !";
                labelunsuccess.Visible = true;
                labelunsuccess.Text = "Password must contain at least 1 letter !";
            }
            else if (password.Any(char.IsDigit) == false && password.Length < 6 && password.Any(char.IsLetter) == true)
            {
                labelunsuccess.Text = "Password length must be at least 6 character !";
                labelunsuccess.Visible = true;
                labelunsuccess.Text = "Password must contain at least 1 number !";
            }
            else
            {
                labelunsuccess.Visible = true;
                labelunsuccess1.Visible = true;
                labelsuccess.Text = "Password length must be at least 6 character !";
                labelunsuccess.Text = "Password must contain at least 1 number !";
                labelunsuccess1.Text = "Password must contain at least 1 letter !";
            }
        }
        private void DataEncryption(string datausername, string datapassword)
        {
            string query = "SELECT COUNT(*) FROM UserInfo WHERE UserName = @username";
            using (SqlCommand checkusername = new SqlCommand(query, connection))
            {
                connection.Open();
                checkusername.Parameters.AddWithValue("@username", datausername);
                int count = (int)checkusername.ExecuteScalar();
                connection.Close();
                if (count == 1)
                {
                    labelusernametaken.Visible = true;
                    labelusernametaken.Text = "This Username is already taken";
                    labelsuccess.Visible = false;
                }
                else
                {
                    GetMaxID();
                    maxid++;
                    connection.Open();
                    string hashedpassword = BCrypt.Net.BCrypt.HashPassword(datapassword);
                    SqlCommand command = new SqlCommand("Insert into UserInfo (ID,UserName,Password) Values ('" + maxid.ToString() + "' , '" + datausername + "' , '" + hashedpassword + "')", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    labelsuccess.Text = "Logged up successfully !";
                    Clearlogup();

                }
            }
        }
        private void buttonlogup_Click(object sender, EventArgs e)
        {
            LogUp();
        }
        private bool CheckUser()
        {
            string query = "SELECT COUNT(*) FROM UserInfo Where UserName = @username";
            using (SqlCommand checkuser = new SqlCommand(query, connection))
            {
                checkuser.Parameters.AddWithValue("@username", textBoxloginusername.Text.ToString());
                connection.Open();
                int count = (int)checkuser.ExecuteScalar();
                connection.Close();
                if (count == 1)
                {
                    DataDecryption(textBoxloginusername.Text);
                }
                else
                {
                    labelloginsuccess.Visible = true;
                    labelloginsuccess.Text = "Wrong Password or Username Try again";
                }
            }

            return true;
        }
        private void DataDecryption(string correctusername)
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT ID FROM UserInfo WHERE UserName = @username", connection))
            {
                command.Parameters.AddWithValue("@username", correctusername);
                string FoundID = command.ExecuteScalar()?.ToString();  // if the left side is null dont read the rest __?
                if (FoundID != null)
                {
                    string passwordpath = "SELECT Password FROM UserInfo WHERE ID = @id";
                    using (SqlCommand passcommand = new SqlCommand(passwordpath, connection))
                    {
                        passcommand.Parameters.AddWithValue("@id", FoundID);
                        string DataBasePassword = passcommand.ExecuteScalar()?.ToString();
                        connection.Close();
                        Login(DataBasePassword);
                    }
                }
            }
        }

        private bool Login(string encryptpassword)
        {
            bool PasswordCheck = BCrypt.Net.BCrypt.Verify(textBoxloginpassword.Text.ToString(), encryptpassword);
            bool isAuthenticated = false;
            if (PasswordCheck)
            {

                labelloginsuccess.Visible = true;
                string query = "Select COUNT(*) From UserInfo Where UserName = @username AND Password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@username", textBoxloginusername.Text.ToString());
                    command.Parameters.AddWithValue("@password", encryptpassword);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        isAuthenticated = true;
                        labelloginsuccess.Text = "Logged in successfully !";
                        Clearlogin();
                        timer1.Start();                       
                    }
                    else
                    {
                        labelloginsuccess.Text = "Wrong Password or Username Try again";

                    }
                }
            }
            else
            {
                labelloginsuccess.Visible = true;
                labelloginsuccess.Text = "Wrong Password or Username Try again";
            }

            connection.Close();
            return isAuthenticated;
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            CheckUser();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Form2 form2 = new Form2();   // do whatever do you want in here 
            form2.Show();
            this.Hide();

        }
    }
}

