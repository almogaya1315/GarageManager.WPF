using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace GarageManager.UI.Controls.Grid
{
    public class CustomGridColumn : DataGridTemplateColumn
    {
        public string DataContext { get; set; }

        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            var contentPresenter = base.GenerateElement(cell, dataItem);

            BindingOperations.SetBinding(contentPresenter, System.Windows.Controls.ContentPresenter.ContentProperty, new Binding(DataContext));

            return contentPresenter;
        }

        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem)
        {
            var contentPresenter = base.GenerateEditingElement(cell, dataItem);

            BindingOperations.SetBinding(contentPresenter, System.Windows.Controls.ContentPresenter.ContentProperty, new Binding(DataContext));

            return contentPresenter;
        }
    }
}
