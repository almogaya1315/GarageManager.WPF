using GarageManager.Core.Bases;
using GarageManager.UI.ViewModels.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Menu
{
    public class MenuViewModel : BaseViewModel
    {
        public MenuViewModel() { }
        public MenuViewModel(ViewModelBrowser browser)
        {
            Browser = browser;
        }
    }
}
