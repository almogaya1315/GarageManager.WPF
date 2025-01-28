//using GalaSoft.MvvmLight;
using CommunityToolkit.Mvvm.ComponentModel;
using GarageManager.Core.Bases;
using GarageManager.UI.Services;
using GarageManager.UI.ViewModels.Menu;
using GarageManager.UI.ViewModels.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Container
{
    public class ContainerViewModel : BaseViewModel
    {
        private VmInjector _injector;

        private ObservableObject _containerContent;
        public ObservableObject ContainerContent
        {
            get { return _containerContent; }
            set
            {
                _containerContent = value;
                RaisePropertyChanged(_containerContent, value); 
            }
        }

        public ContainerViewModel()
        {
            _injector = new VmInjector(this);

            Browsed(new BrowseArgs(BrowseArgsType.MenuArgs));
        }

        public void Browsed(BrowseArgs args)
        {
            switch (args.Type)
            {
                case BrowseArgsType.MenuArgs:
                    ContainerContent = _injector.New<MenuViewModel>();
                    break;
                case BrowseArgsType.NewService:
                    ContainerContent = _injector.New<ServiceViewModel>();
                    break;
            }
        }
    }
}
