using GalaSoft.MvvmLight.Command;
using GarageManager.Core.Bases;
using GarageManager.UI.ViewModels.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GarageManager.UI.ViewModels.Menu
{
    public class MenuViewModel : BaseViewModel
    {
        public MenuViewModel() { }
        public MenuViewModel(ViewModelBrowser browser)
        {
            Browser = browser;

            NewService = new RelayCommand(ExecuteNewService);
            LoadService = new RelayCommand(ExecuteLoadService);
        }

        public ICommand NewService { get; set; }
        public ICommand LoadService { get; set; }

        private void ExecuteNewService()
        {
            Browser.Browse(new BrowseArgs(BrowseArgsType.NewService));
        }

        private void ExecuteLoadService()
        {
            Browser.Browse(new BrowseArgs(BrowseArgsType.LoadService));
        }
    }
}
