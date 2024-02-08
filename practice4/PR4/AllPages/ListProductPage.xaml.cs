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
    /// <summary>
    /// Логика взаимодействия для ListProductPage.xaml
    /// </summary>
    public partial class ListProductPage : Page
    {
        public ListProductPage()
        {
            InitializeComponent();
        }

        private void ListBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ListProduct.ItemsSource = MainWindow.entities.Products.ToList();
        }

        private void ListProduct_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void addToOrder(object sender, RoutedEventArgs e)
        {
            SportDataBaseEn sportDataBaseEn = new SportDataBaseEn();
            int index = ListProduct.SelectedIndex;
            
            showDetails.Visibility = Visibility.Visible;

        }

        private void showDetails_Click(object sender, RoutedEventArgs e)
        {
            
            BasketWindow basketWindow = new BasketWindow();
            basketWindow.Show();
        }
    }
}
