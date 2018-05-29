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
    /// Interaction logic for WebPage.xaml
    /// </summary>
    public partial class WebPage : Page
    {
        public WebPage()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            DistributorList DistributorListPage = new DistributorList();
            this.NavigationService.Navigate(DistributorListPage);

        }

    }
}
