using System;

using System.Windows;
using System.Windows.Input;

namespace SwitchParsecConnection
{
    class MessageCommandParsecSettings : ICommand
       
    {
        public void Execute(object parameter)
        {
            // execute message here
            // MessageBox.Show("hello");
            //get current main window
            var mainwindow = (Application.Current.MainWindow as MainWindow);
            if (!mainwindow.IsVisible)
            {
                mainwindow.Show();
            }
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
