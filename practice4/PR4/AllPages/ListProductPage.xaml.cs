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

namespace PR4.AllPages
{
    public partial class ListProductPage : Page
    {
        database db = new database();
        public ListProductPage()
        {
            InitializeComponent();
            
        }
        public static List<int> list_products = new List<int>();
        private void ListBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListProduct.ItemsSource = MainWindow.entities.products.ToList();
        }

        private void ListProduct_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void addToOrder(object sender, RoutedEventArgs e)
        {
            
            int indexProduct = ListProduct.SelectedIndex;
            list_products.Add(indexProduct + 1);
            showDetails.Visibility = Visibility.Visible;

        }

        private void showDetails_Click(object sender, RoutedEventArgs e)
        {
            
            BasketWindow basketWindow = new BasketWindow();
            basketWindow.Show();
        }
    }
}
