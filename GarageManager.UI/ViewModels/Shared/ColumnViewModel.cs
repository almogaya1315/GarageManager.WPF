using GarageManager.UI.ViewModels.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManager.UI.ViewModels.Shared
{
    public class ColumnViewModel : BaseViewModel
    {
        public string Header { get; set; }
        public double? Width { get; set; }
        public string HeaderTemplate { get; set; }
        public string EditingTemplate { get; set; }
        public string Template { get; set; }
        public string DataContextPath { get; set; }
    }
}
