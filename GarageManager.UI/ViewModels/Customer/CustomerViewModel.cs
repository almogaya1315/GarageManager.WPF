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
        private CustomerModel _customer;

        public CustomerViewModel(int id)
        {
            _customer = new CustomerModel(id);
        }

        public string FullName 
        {
            get
            {
                return _customer.FullName;
            }
            set
            {
                _customer.FullName = value;
                RaisePropertyChanged();
            }
        }
    }
}
