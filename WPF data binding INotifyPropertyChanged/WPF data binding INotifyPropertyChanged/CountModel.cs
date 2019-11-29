using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_data_binding_INotifyPropertyChanged.Annotations;

namespace WPF_data_binding_INotifyPropertyChanged
{
    public class CountModel : INotifyPropertyChanged
    {
        private int counter;

        public int Counter
        {
            get { return counter; }
            set
            {
                counter = value;
                OnPropertyChanged(nameof(Counter));
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        


    }
}
