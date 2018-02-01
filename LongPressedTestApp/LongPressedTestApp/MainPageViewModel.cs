using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace LongPressedTestApp
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Message)));
            }
        }
        public Command LongPressed { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            LongPressed = new Command(() => Message = "Long pressed");
        }
    }
}
