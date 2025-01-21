using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using GarageManager.UI.ViewModels.Shared;

namespace GarageManager.UI.Controls.Grid
{
    public class CustomGrid : System.Windows.Controls.DataGrid
    {
        public List<ColumnViewModel> ColumnBindings
        {
            get { return (List<ColumnViewModel>)GetValue(ColumnBindingsProperty); }
            set { SetValue(ColumnBindingsProperty, value); }
        }

        public static readonly DependencyProperty ColumnBindingsProperty =
            DependencyProperty.Register("ColumnBindings",
                typeof(List<ColumnViewModel>), typeof(CustomGrid),
                new PropertyMetadata(null, ColumnBindingsPropertyChanged));

        private static void ColumnBindingsPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var grid = (CustomGrid)d;
            if (grid == null) return;

            var columns = (List<ColumnViewModel>)grid.GetValue(ColumnBindingsProperty);
            if (columns == null || columns.Count == 0) return;

            foreach (var column in columns)
            {
                var gridColumn = new CustomGridColumn()
                {
                    Header = column.Header,
                    CellTemplate = (DataTemplate)grid.FindResource(column.Template),
                    DataContext = column.DataContextPath,
                };

                if (column.Width.HasValue)
                {
                    gridColumn.Width = new DataGridLength(column.Width.Value, DataGridLengthUnitType.Pixel);
                }

                if (column.HeaderTemplate != null)
                {
                    gridColumn.HeaderTemplate = (DataTemplate)grid.FindResource(column.HeaderTemplate);
                }

                if (column.EditingTemplate != null)
                {
                    gridColumn.CellEditingTemplate = (DataTemplate)grid.FindResource(column.EditingTemplate);
                }

                grid.Columns.Add(gridColumn);
            }
        }

    }
}
