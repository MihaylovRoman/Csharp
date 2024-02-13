using PR4.AllPages;
using PR4.components;
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

namespace PR4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static database entities = new database();
        ListProductPage listProductPage;
        authWindow authWindow;
        public UserClass userClass = new UserClass();
        public MainWindow()
        {        
            InitializeComponent();
            listProductPage = new ListProductPage();

        }
       
        private void ListBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
        }

        private void MainFrame1_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void authBtn_Click(object sender, RoutedEventArgs e)
        {
            authWindow = new authWindow();
            authWindow.Show();
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (userClass.role == "Клиент")
            {
                listProductPage.addOrder.IsEnabled = true;
            }
            else if (userClass.role == "Сотрудник")
            {

            }
            else
            {
                listProductPage.addOrder.IsEnabled = false;
            }
            MainFrame1.Navigate(listProductPage);
        }
    }
}
