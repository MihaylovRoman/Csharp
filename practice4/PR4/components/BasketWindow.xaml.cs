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
    public partial class BasketWindow : Window
    {
        database entities = MainWindow.entities;
        List<int> list_product = ListProductPage.list_products;
        List<productClass> products = ListProductPage.products;
        ListProductPage listProductPage;

        public BasketWindow(ListProductPage listProductPage)
        {
            InitializeComponent();
            this.listProductPage = listProductPage;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pickup.ItemsSource = entities.pickup_point.Select(x => x.city + ", " + x.street + ", " + x.house).ToList();
            labelOrder.Content = entities.order_product.Count() + 1;
        }

        private void ListProduct_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void deleteProduct(object sender, RoutedEventArgs e)
        {
            int indexProduct = ListProduct.SelectedIndex;
            products.RemoveAt(indexProduct);

            list_product.RemoveAt(indexProduct);
            ListProduct.ItemsSource = null;
            var Cart = entities.products.Where(x => list_product.Contains(x.id)).ToList();
            ListProduct.ItemsSource = Cart;
            labelSum.Content = Cart.Sum(x => x.cost);
        }

        private void ListBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void createOrder_Click(object sender, RoutedEventArgs e)
        {

            int order_id = entities.order_product.Count() + 1;


            for (int i = 0; i < ListProduct.Items.Count; i++)
            {
                int id = entities.order_product.Count() + 1;
                order_prod listOrder = new order_prod(id, products[i].id, order_id, 1);
                entities.order_product.Add(listOrder);
            }
        }
        
        public class order_prod
        {
            public int id;
            public int product_id;
            public int order_id;
            public int count;

            public order_prod(int id, int id1, int id2, int count)
            {
                this.id = id;
                this.product_id = id1;
                this.order_id = id2;
                this.count = count;
            }

        }
    }
}
