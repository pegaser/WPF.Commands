using System;
using System.Windows;
using System.Windows.Input;

namespace Practice
{
    internal class MessageCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            string msg;
            if (parameter == null)
                msg = "Button Clickeado!";
            else
                msg = parameter.ToString();

            MessageBox.Show(msg);
        }
    }
}
