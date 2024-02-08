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
        public static SportDataBaseEn entities = new SportDataBaseEn();
        public MainWindow()
        {        
            InitializeComponent();
            MainFrame1.Navigate(new AllPages.ListProductPage());
            
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
            components.authWindow authWindow = new components.authWindow();
            authWindow.Show();
        }
    }
}
