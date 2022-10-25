using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Practice
{
    public class MyDataContext
    {
        ICommand _messageCommand = new MessageCommand();
        public ICommand MessageCommand
        {
            get { return _messageCommand; }
        }
    }
}
