using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFNotesApp.Model;

namespace WPFNotesApp.ViewModel.Commands
{
    public class NewNoteCommand : ICommand
    {
        public NotesVM Vm { get; set; }


        public NewNoteCommand(NotesVM vm)
        {
            Vm = vm;
        }

        public bool CanExecute(object parameter)
        {
            Notebook selectedNotebook = parameter as Notebook;

            if (selectedNotebook != null)
            {
                return true;
            }

            return false;
        }

        public void Execute(object parameter)
        {
            Notebook selectedNotebook = parameter as Notebook;
            Vm.CreateNote(selectedNotebook.Id);
        }

        public event EventHandler CanExecuteChanged;
    }
}
