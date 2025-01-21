using GarageManager.UI.ViewModels.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Shared
{
    public class CellViewModel : BaseViewModel
    {
        private object _value;
        public virtual object Value
        {
            get { return _value; }
            set
            {
                _value = value;
                RaisePropertyChanged();
            }
        }

        public CellViewModel(object value)
        {
            Value = value;
        }
    }
}
