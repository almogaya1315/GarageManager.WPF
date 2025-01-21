using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Shared
{
    public class EditingCellViewModel : CellViewModel
    {
        //private ColumnName? _column;

        public bool IsEnabled { get; set; }

        private object _value;
        public override object Value
        {
            get { return _value; }
            set
            {
                if (Equals(_value, value)) return;

                _value = value;
                RaisePropertyChanged();
            }
        }

        public void SetValueToBinding(object value)
        {
            if (!Equals(Value, value)) _value = value;
            RaisePropertyChanged("Value");
        }

        public EditingCellViewModel(object value, bool isEnabled = true) : base(value)
        {
            IsEnabled = isEnabled;
        }
    }
}
