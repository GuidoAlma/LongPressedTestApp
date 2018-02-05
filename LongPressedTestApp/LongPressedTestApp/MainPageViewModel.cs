using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace LongPressedTestApp
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _labelText;
        public string LabelText
        {
            get
            {
                return _labelText;
            }
            set
            {
                _labelText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LabelText)));
            }
        }

        private string _stackText;
        public string StackText
        {
            get
            {
                return _stackText;
            }
            set
            {
                _stackText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StackText)));
            }
        }

        private string _entryText;
        public string EntryText
        {
            get
            {
                return _entryText;
            }
            set
            {
                _entryText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EntryText)));
            }
        }

        private string _buttonText;
        public string ButtonText
        {
            get
            {
                return _buttonText;
            }
            set
            {
                _buttonText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonText)));
            }
        }
        public Command LongPressedLabel { get; set; }
        public Command LongPressedStack { get; set; }
        public Command LongPressedEntry { get; set; }
        public Command LongPressedButton { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            StackText = "Stack Long Press Test";
            LabelText = "Label Long Press Test";
            EntryText = "Long press to clear me";
            ButtonText = "Button test";

            LongPressedLabel = new Command(() => LabelText = "Long pressed");

            LongPressedStack = new Command(() => StackText = "Long pressed");

            LongPressedEntry = new Command(() => EntryText = "");

            LongPressedButton = new Command(() =>ButtonText = "Long pressed");
        }
    }
}
