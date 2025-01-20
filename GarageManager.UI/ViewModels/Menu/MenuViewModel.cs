using GalaSoft.MvvmLight.Command;
using GarageManager.BL.Repositories;
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
        private readonly IRepository _garageRepo;

        public MenuViewModel() { }
        public MenuViewModel(ViewModelBrowser browser)
        {
            Browser = browser;

            NewService = new RelayCommand(ExecuteNewService);
            LoadService = new RelayCommand(ExecuteLoadService);

            TestGetCars = new RelayCommand(ExecuteTestGetCars);

            _garageRepo = new GarageRepository();
        }

        public ICommand NewService { get; set; }
        public ICommand LoadService { get; set; }


        public ICommand TestGetCars { get; set; }

        private void ExecuteNewService()
        {
            Browser.Browse(new BrowseArgs(BrowseArgsType.NewService));
        }

        private void ExecuteLoadService()
        {
            Browser.Browse(new BrowseArgs(BrowseArgsType.LoadService));
        }

        private void ExecuteTestGetCars()
        {
            var result = _garageRepo.GetCars();
            
        }
    }
}
