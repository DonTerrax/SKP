using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FoodProgram.Class
{
    class CheckUserInfo
    {
        public void CheckUserName(string userName)
        {

            if (userName.Length < 4)
            {
                MessageBox.Show("Username minimum 4 characters");
            }
            else if (userName.Length > 15)
            {
                MessageBox.Show("Username maximum 15 characters");
            }

        }

        public void CheckPassword(string password, string confirmPassword)
        {

            if (password == confirmPassword)
            {
                if (password.Length < 4)
                {
                    MessageBox.Show("Password must be minimum 4 characters");
                }
                else if (password.Length > 15)
                {
                    MessageBox.Show("Password must be under 16 characters");
                }
            }
            else
            {
                MessageBox.Show("Password is not identical");
            }

        }

        public void CheckEmail(string email, string confirmEmail)
        {
            if (email == confirmEmail)
            {
                if (email.Contains("@"))
                {
                    
                }
                else
                {
                    MessageBox.Show("Email must contain @");
                }
            }
            else if (email != confirmEmail)
            {
                MessageBox.Show("Email does not match");
            }
           
           

        }
    }
}
