using System;
using System.Collections.Generic;
using System.Drawing;
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
using static System.Net.Mime.MediaTypeNames;

namespace PR4.components
{
    /// <summary>
    /// Логика взаимодействия для authWindow.xaml
    /// </summary>
    public partial class authWindow : Window
    {
        public authWindow()
        {
            InitializeComponent();
            
        }
        SportDataBaseEn SportDataBaseEn = new SportDataBaseEn();
        int invalidPassword = 0;


        private void auth_Click(object sender, RoutedEventArgs e)
        {
            string login = inputLogin.Text;
            string password = inputPass.Password;
            string capcha = inputCapcha.Text;
            string createcapcha = "";

            if (CheckUser(login, password) && capcha == createcapcha)
            {
                // Successful login, do something
            }
            else
            {
                invalidPassword++;
                if (invalidPassword == 3)
                {
                    createcapcha = createCAPCHA();
                    imageCapcha.Text = createcapcha;
                    inputCapcha.Visibility = Visibility.Visible;
                    imageCapcha.Visibility = Visibility.Visible;
                }
            }
        }

        public bool CheckUser(string login, string password)
        {
            using (var context = new SportDataBaseEn())
            {
                var employee = context.Employees.FirstOrDefault(e => e.login == login);

                if (employee == null)
                {
                    MessageBox.Show("Такой пользователь не найден");
                    return false;
                }

                if (employee.password != password)
                {
                    MessageBox.Show("Неправильный логин или пароль");
                    return false;
                }

                // Successful login
                // Do any additional checks or actions here

                return true;
            }
        }


        private string createCAPCHA()
        {
            Random rnd = new Random();
            string capchaText = "";
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";

            for(int i = 0; i < 6; i++)
            {
                capchaText += ALF[rnd.Next(ALF.Length)];
            }
            return capchaText;




        }
        

        
    }
}
