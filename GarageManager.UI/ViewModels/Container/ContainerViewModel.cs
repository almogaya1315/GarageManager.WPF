using GalaSoft.MvvmLight;
using GarageManager.Core.Bases;
using GarageManager.UI.Services;
using GarageManager.UI.ViewModels.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Container
{
    internal class ContainerViewModel : ViewModel
    {
        private VmInjector _injector;

        private ViewModelBase _containerContent;
        public ViewModelBase ContainerContent
        {
            get { return _containerContent; }
            set
            {
                _containerContent = value;
                RaisePropertyChanged();
            }
        }

        public ContainerViewModel()
        {
            _injector = new VmInjector(this);

            //Browsed(new BrowseArgs(BrowseArgsType.MenuArgs));
        }

        //public void Browsed(BrowseArgs args)
        //{
        //    switch (args.Type)
        //    {
        //        case BrowseArgsType.MenuArgs:
        //            ContainerContent = _injector.New<MenuViewModel>();
        //            break;
        //    }
        //}
    }
}
