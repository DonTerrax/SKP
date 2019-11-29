using System.ComponentModel;
using System.Runtime.CompilerServices;
using FoodProgram.Annotations;


namespace FoodProgram 
{
    class Signup : INotifyPropertyChanged
    {
        public string query;
        public void CreateUserName()
        {
            DatabaseConnection conn = new DatabaseConnection();
            conn.OpenDbCon();
            query = "INSERT INTO Customer(User_Name,Password,Email) VALUES()";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
