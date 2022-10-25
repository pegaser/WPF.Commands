using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace HomeworkResolved
{
    public class MessageCommand : ICommand
    {
        public void Execute(object parameter)
        {
            string msg;

            if (parameter == null)
                msg = "Button Clickeado!";
            else
                msg = parameter.ToString();

            MessageBox.Show(msg);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
