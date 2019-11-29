using System.ComponentModel;
using System.Runtime.CompilerServices;
using FoodProgram.Annotations;

namespace FoodProgram.Class
{
    class User : INotifyPropertyChanged
    {
        private string username;
        private string password;
        private string email;
        private string confirmEmail;
        private string confirmPassword;

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value; OnPropertyChanged(nameof(ConfirmPassword));
            }
        }


        public string ConfirmEmail
        {
            get { return confirmEmail; }
            set
            {
                confirmEmail = value; OnPropertyChanged(nameof(ConfirmEmail));
            }
        }

        public string Email
        {
            get => email;
            set
            {
                email = value; OnPropertyChanged(nameof(Email));
            }
        }

        public string Username
        {
            get => username;
            set
            {
                username = value; OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => password;
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
