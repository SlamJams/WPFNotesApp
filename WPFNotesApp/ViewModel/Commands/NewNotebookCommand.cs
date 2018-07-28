using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFNotesApp.ViewModel.Commands
{
    public class NewNotebookCommand : ICommand
    {

        public NotesVM Vm { get; set; }


        public NewNotebookCommand(NotesVM vm)
        {
            Vm = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Vm.CreateNotebook();
        }

        public event EventHandler CanExecuteChanged;
    }
}
