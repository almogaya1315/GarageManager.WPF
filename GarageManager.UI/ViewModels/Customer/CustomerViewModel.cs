using GarageManager.UI.Models;
using GarageManager.UI.ViewModels.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Customer
{
    public class CustomerViewModel : BaseViewModel
    {
        private CustomerModel _model;

        public CustomerViewModel(int id)
        {
            _model = new CustomerModel(id);
        }

        public string FullName 
        {
            get
            {
                return _model.FullName;
            }
            set
            {
                _model.FullName = value;
                RaisePropertyChanged();
            }
        }
    }
}
