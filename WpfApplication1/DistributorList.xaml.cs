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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for DistributorList.xaml
    /// </summary>
    public partial class DistributorList : Page
    {
        public DistributorList()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a List of objects.

            DBParadoxEntities db = new DBParadoxEntities();
            var empQuery = from emp in db.DISTRIBUTORs
                           select emp;

            List<DISTRIBUTOR> items = new List<DISTRIBUTOR>();
            items = empQuery.ToList();
   
           // ... Assign ItemsSource of DataGrid.
            var grid = sender as DataGrid;
            grid.ItemsSource = items;
        }
       

    }
}
