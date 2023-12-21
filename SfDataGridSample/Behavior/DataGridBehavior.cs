using SfDataGridSample.Converter;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample.Behaviors
{
    public class DataGridBehavior : Behavior<SfDataGrid>
    {
        protected override void OnAttachedTo(SfDataGrid dataGrid)
        {
            dataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
            base.OnAttachedTo(dataGrid);
        }

        private void DataGrid_AutoGeneratingColumn(object? sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.MappingName == "Name")
            {
                e.Column.DisplayBinding = new Binding(".", BindingMode.Default, new ConvertCustomerName());
            }
        }

        protected override void OnDetachingFrom(SfDataGrid dataGrid)
        {
            dataGrid.AutoGeneratingColumn -= DataGrid_AutoGeneratingColumn;
            base.OnDetachingFrom(dataGrid);
        }
    }
}
