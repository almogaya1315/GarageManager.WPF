//using GalaSoft.MvvmLight;
using CommunityToolkit.Mvvm.ComponentModel;
using GarageManager.Core.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Container
{ 
    public class BaseViewModel : ObservableObject
    {
        public BaseApplication App { get; set; }

        public ViewModelBrowser Browser { get; set; }

        //public ISquadRepository SquadRepository { get; set; }

        //public CollectionFactory Collections { get; set; }

        protected void RaisePropertyChanged(ObservableObject obj, object value, string propertyName = null)
        {
            
            if (SetProperty(ref obj, (ObservableObject)value, propertyName)) // Automatically calls OnPropertyChanged internally
            {
                OnPropertyChanged(nameof(obj)); // Notify for dependent property
            }
        }
    }
}
