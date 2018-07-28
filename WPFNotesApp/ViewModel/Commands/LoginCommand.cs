using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFNotesApp.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {

        public LoginVM Vm { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;        
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;

        public LoginCommand(LoginVM vm)
        {
            Vm = Vm;
        }
    }
}
