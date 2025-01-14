using GalaSoft.MvvmLight;
using GarageManager.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Container
{ 
    public class BaseViewModel : ViewModelBase
    {
        public BaseApplication App { get; set; }

        public ViewModelBrowser Browser { get; set; }

        //public ISquadRepository SquadRepository { get; set; }

        //public CollectionFactory Collections { get; set; }
    }
}
