using PR4.AllPages;
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
using System.Windows.Shapes;

namespace PR4
{
    /// <summary>
    /// Логика взаимодействия для BasketWindow.xaml
    /// </summary>
    public partial class BasketWindow : Window
    {
        public static database entities = new database();
        List<int> list_product = ListProductPage.list_products;

        public BasketWindow()
        {
            InitializeComponent();
            var Cart = entities.products.Where(x => list_product.Contains(x.id)).ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var Cart = entities.products.Where(x => list_product.Contains(x.id)).ToList();
            ListProduct.ItemsSource = Cart;          
            pickup.ItemsSource = entities.pickup_point.Select(x => x.city + ", " + x.street + ", " + x.house).ToList();
            labelSum.Content = Cart.Sum(x => x.cost);
            labelOrder.Content = entities.order_product.Count() + 1;

        }

        private void ListProduct_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void deleteProduct(object sender, RoutedEventArgs e)
        {
            int indexProduct = ListProduct.SelectedIndex;
            list_product.RemoveAt(indexProduct);
            ListProduct.ItemsSource = null;
            var Cart = entities.products.Where(x => list_product.Contains(x.id)).ToList();
            ListProduct.ItemsSource = Cart;
        }

        private void ListBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
