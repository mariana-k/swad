using CD3_Kyrkosh.ViewModel;
using CodingDojo4DataLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CD3_Kyrkosh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /*  private void Button_Click(object sender, RoutedEventArgs e)
          {

              var selectedRow = dataGrid.SelectedItem;
              var selectedIndex = dataGrid.SelectedIndex;
              dataGrid.BeginEdit();
          }*/
        private void _showCellsEditingTemplate(DataGridRow row)
        {
            foreach (DataGridColumn col in dataGrid.Columns)
            {
                DependencyObject parent = VisualTreeHelper.GetParent(col.GetCellContent(row));
                while (parent.GetType().Name != "DataGridCell")
                    parent = VisualTreeHelper.GetParent(parent);

                DataGridCell cell = ((DataGridCell)parent);
                DataGridTemplateColumn c = (DataGridTemplateColumn)col;
                if (c.CellEditingTemplate != null)
                    cell.Content = ((DataGridTemplateColumn)col).CellEditingTemplate.LoadContent();
            }
        }
        public IEnumerable<DataGridRow> GetDataGridRows(DataGrid grid)
        {
            var itemsSource = grid.ItemsSource as IEnumerable;
            if (null == itemsSource) yield return null;
            foreach (var item in itemsSource)
            {
                var row = grid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (null != row) yield return row;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var row_list = GetDataGridRows(dataGrid);
            foreach (DataGridRow single_row in row_list)
            {
                if (single_row.IsSelected == true)
                {
                    _showCellsEditingTemplate(single_row);
                    MessageBox.Show("the row no." + single_row.GetIndex().ToString() + " is selected!");
                }
            }

            // DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromItem(dataGrid.CurrentItem);
            
        }
        /* private void EditRow(object sender, DataGridBeginningEditEventArgs e)
         {
             try
             {
                 object item = dataGrid.SelectedItem;
                 //  var isReadOnlyRow = ReadOnlyService.GetIsReadOnly(e.Row);
                 // if (isReadOnlyRow)
                // e.Cancel = true;

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 return;
             }
         }*/


    }

}
