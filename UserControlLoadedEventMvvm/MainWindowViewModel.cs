using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace UserControlLoadedEventMvvm
{
    public class MainWindowViewModel
    {

        #region Constructor
        public MainWindowViewModel()
        {
            InitializeCommands();
        }
        #endregion

        #region Commands
        public ICommand LoadedCommand { get; set; }

        private void InitializeCommands()
        {
            LoadedCommand = new CustomCommand(OnUserControlLoaded, CanUserControlLoadedExecute);

        }

        private bool CanUserControlLoadedExecute(object obj)
        {
            return true;
        }

        private void OnUserControlLoaded(object obj)
        {
            MessageBox.Show("User Control Loaded!", "Event Fired!!!", MessageBoxButton.OK);
        }
        #endregion

    }
}
