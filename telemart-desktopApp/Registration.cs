using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telemart_desktopApp
{
    class Registration
    {
        public static string name;
        public static string email;
        public static string password;
        public void register(string username, string useremail, string userpass)
        {
            if (username == "" || useremail == "" || userpass == "")
            {
                MessageBox.Show("Fields Required***");
            }
            else
            {
                name = username;
                email = useremail;
                password = userpass;
                Login lg = new Login();
                Form1 f1 = new Form1();
                f1.Hide();
                lg.Show();

            }


        }
        public void loginCheck(string userEmail,string userPassword)
        {
            if (email == userEmail && password == userPassword)
            {
                MessageBox.Show("Successfully Loggged In");
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password");
            }
        }

    }
}
