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
        database db = MainWindow.entities;
        MainWindow mainWindow;
        BasketWindow basketWindow;
        public static List<productClass> products;
        public ListProductPage()
        {
            InitializeComponent();
            basketWindow = new BasketWindow(this);

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



            var prod = db.products.FirstOrDefault(x => x.id == indexProduct);
            productClass newProduct = new productClass(prod.id, prod.fabricator_id, prod.title, prod.description, prod.image, prod.amount, prod.discount, prod.cost);

            list_products.Add(indexProduct + 1);

            products.Add(newProduct);
            var Cart = db.products.Where(x => list_products.Contains(x.id)).ToList();


            showDetails.Visibility = Visibility.Visible;


            basketWindow.labelSum.Content = Cart.Sum(x => x.cost);


            basketWindow.ListProduct.ItemsSource = Cart;

        }

        private void showDetails_Click(object sender, RoutedEventArgs e)
        {
            basketWindow.Show();
        }
    }
}
