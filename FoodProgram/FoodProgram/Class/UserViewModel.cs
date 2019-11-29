using System;
using System.Windows;

namespace FoodProgram.Class
{
    class UserViewModel
    {
        public User User { get; set; }

        public RelayCommand CreateAccountCommand { get;  }


        public UserViewModel()
        {
            User = new User();
            CreateAccountCommand = new RelayCommand(CanCreateAccount, CreateAccount);
        }

        private void CreateAccount(object obj)
        {
            try
            {
                CreateUserAccount usertodb = new CreateUserAccount();
                CheckUserInfo user = new CheckUserInfo();
                user.CheckUserName(User.Username);
                user.CheckPassword(User.Password, User.ConfirmPassword);
                user.CheckEmail(User.Email, User.ConfirmEmail);
                usertodb.SendToDB(User.Username,User.Password,User.Email);
            }
            catch (Exception e)
            {
                MessageBox.Show("All input fields are required");
                
            }
            
        }

        private bool CanCreateAccount(object obj)
        {
            return true;
        }
    }
}
