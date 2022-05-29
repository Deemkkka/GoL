using System.Windows;
using System.Windows.Input;
using GoL.ViewModels.Base;
using GoL.Infrastructure.Commands;

namespace GoL.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        #region Команды

        #region CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion


        #endregion


        public MainWindowViewModel()
        {

            #region Commands

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationExecute);

            #endregion

        }
    }
}
