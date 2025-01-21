using GarageManager.UI.Models;
using GarageManager.UI.ViewModels.Container;
using GarageManager.UI.ViewModels.Shared;
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

        public CustomerViewModel(int id, string fullName)
        {
            _model = new CustomerModel(id, fullName);

            Id = new CellViewModel(id);
            FullName = new CellViewModel(_model.FullName);
        }

        public int IdInt
        {
            get { return _model.Id; }
            set { _model.Id = value; }
        }

        public string FullNameStr
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

        public CellViewModel Id { get; set; }
        public CellViewModel FullName { get; set; }
    }
}
