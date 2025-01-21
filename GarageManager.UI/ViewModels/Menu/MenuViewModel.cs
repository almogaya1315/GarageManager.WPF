using GalaSoft.MvvmLight.Command;
using GarageManager.BL.Repositories;
using GarageManager.Core.Bases;
using GarageManager.UI.Controls.Grid;
using GarageManager.UI.ViewModels.Container;
using GarageManager.UI.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace GarageManager.UI.ViewModels.Menu
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IRepository _garageRepo;

        public List<ComboBoxItem> TestComboItems { get; set; }
        public List<ColumnViewModel> GridColumns { get; set; }


        private ComboBoxItem? _selectedTestComboboxItem;
        public ComboBoxItem? SelectedTestComboboxItem
        {
            get 
            { 
                return _selectedTestComboboxItem;
            }
            set
            {
                _selectedTestComboboxItem = value;
                RaisePropertyChanged();
            }
        }

        private bool _isCheckedTest;
        public bool IsCheckedTest
        {
            get
            {
                return _isCheckedTest;
            }
            set
            {
                _isCheckedTest = value;
                var nextIndex = SelectedTestComboboxItem != null ? (int?)(int.Parse((string)SelectedTestComboboxItem.Content)) : null;
                SelectedTestComboboxItem = DefaultSelectedItem(nextIndex);
                //RaisePropertyChanged("SelectedTestComboboxItem", newValue: DefaultSelectedItem(nextIndex));
                RaisePropertyChanged();
            }
        }

        public MenuViewModel() { }
        public MenuViewModel(ViewModelBrowser browser)
        {
            Browser = browser;

            NewService = new RelayCommand(ExecuteNewService);
            LoadService = new RelayCommand(ExecuteLoadService);

            TestGetCars = new RelayCommand(ExecuteTestGetCars);

            _garageRepo = new GarageRepository();



            TestComboItems = new List<ComboBoxItem> 
            {
                new ComboBoxItem { Name = "one", Content = "1" },
                new ComboBoxItem { Name = "two", Content = "2" },
                new ComboBoxItem { Name = "three", Content = "3" },
                new ComboBoxItem { Name = "four", Content = "4" },
                new ComboBoxItem { Name = "five", Content = "5" },
            };
            SelectedTestComboboxItem = DefaultSelectedItem();
            IsCheckedTest = true;



            GridColumns = new List<ColumnViewModel> 
            {
                new ColumnViewModel{ Header = "one", DataContextPath = "Id", Width = 100, Template = "TextTemplate", EditingTemplate = "TextEditingTemplate" },
                new ColumnViewModel{ Header = "two", DataContextPath = "Name", Width = 100, Template = "TextTemplate", EditingTemplate = "TextEditingTemplate" },
                new ColumnViewModel{ Header = "three", DataContextPath = "country", Width = 100, Template = "ComboTemplate", EditingTemplate = "ComboEditingTemplate" },
                new ColumnViewModel{ Header = "four", DataContextPath = "isOk", Width = 100, Template = "CheckTemplate", EditingTemplate = "CheckEditingTemplate" },
            };
        }

        private ComboBoxItem? DefaultSelectedItem(int? index = null)
        {
            if (index.HasValue && index.Value > TestComboItems.Count - 1) index = 0;
            return index.HasValue ? TestComboItems.ElementAt(index.Value) : TestComboItems.FirstOrDefault();
        }

        public ICommand NewService { get; set; }
        public ICommand LoadService { get; set; }


        public ICommand TestGetCars { get; set; }

        private void ExecuteNewService()
        {
            Browser.Browse(new BrowseArgs(BrowseArgsType.NewService));
        }

        private void ExecuteLoadService()
        {
            Browser.Browse(new BrowseArgs(BrowseArgsType.LoadService));
        }

        private void ExecuteTestGetCars()
        {
            var result = _garageRepo.GetCars();
            
        }
    }
}
