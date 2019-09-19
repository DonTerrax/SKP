using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows;


namespace FoodProgram
{
    public abstract class Database : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;


        private static CoreDispatcher dispatcher = Window.Current.Dispatcher;

        protected async virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                () =>
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                });


        }


    }

}
