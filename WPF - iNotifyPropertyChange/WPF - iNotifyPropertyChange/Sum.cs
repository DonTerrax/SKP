using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF___iNotifyPropertyChange
{
    public class Sum : INotifyPropertyChanged
    {
        private string num1;
        private string num2;
        private string result;

        public string Num1
        {
            get
            {
                return num1;
            }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num1 = value;
                {
                    OnProtertyChanged("Num1");
                }
            }
        }

        public string Num2
        {
            get
            {
                return num2;
            }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num2 = value;
                {
                    OnProtertyChanged("Num2");
                }
            }
        }

        public string Result
        {
            get
            {
                int res = int.Parse(num1) + int.Parse(num2);
                return res.ToString();
            }
            set
            {
                int res = int.Parse(num1) + int.Parse(num2);
                result = res.ToString();
                OnProtertyChanged("Result");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnProtertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(property));
            }
        }
    }
}
