using System.Windows;
using GoL.Infrastructure.Commands.Base;

namespace GoL.Infrastructure.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object paramater) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    
    }
}
