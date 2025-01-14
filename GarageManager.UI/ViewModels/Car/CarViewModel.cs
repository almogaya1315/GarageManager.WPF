using GarageManager.Core.Enums;
using GarageManager.UI.Models;
using GarageManager.UI.ViewModels.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Car
{
    public class CarViewModel : BaseViewModel
    {
        private CarModel _model;

        public CarViewModel(int id)
        {
            _model = new CarModel(id);
        }

        public eCarTypes Type
        {
            get
            {
                return _model.Type;
            }
            set
            {
                _model.Type = value;
                RaisePropertyChanged();
            }
        }
    }
}
