using System;
using System.Collections.Generic;
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
        
        private void dataGridView1_CellContentClick(object sender, RoutedEventArgs e)
        {
            dataGrid1.IsReadOnly = false;
            
        }

        private void dataGrid1_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (this.dataGrid1.SelectedItem != null)
            {
                (sender as DataGrid).RowEditEnding -= dataGrid1_RowEditEnding;
                (sender as DataGrid).CommitEdit();
                (sender as DataGrid).Items.Refresh();
                (sender as DataGrid).RowEditEnding += dataGrid1_RowEditEnding;
                dataGrid1.IsReadOnly = true;
            }
            else
            {
                return;
            }
        }
    }
}
