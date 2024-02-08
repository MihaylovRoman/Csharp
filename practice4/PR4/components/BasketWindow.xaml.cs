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
        public static SportDataBaseEn entities = new SportDataBaseEn();
        public BasketWindow()
        {

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ListProduct.ItemsSource = BasketWindow.entities.Products.ToList();

        }

        private void ListProduct_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void del(object sender, RoutedEventArgs e)
        {

        }

        private void ListBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
