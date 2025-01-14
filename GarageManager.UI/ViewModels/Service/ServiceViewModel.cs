using GarageManager.UI.ViewModels.Container;
using GarageManager.UI.ViewModels.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Service
{
    public class ServiceViewModel : BaseViewModel
    {
        public ServiceViewModel() { }

        public ServiceViewModel(ViewModelBrowser browser)
        {
            Browser = browser;

            Customer = new CustomerViewModel(-1);
        }

        public CustomerViewModel Customer { get; set; }
    }
}
