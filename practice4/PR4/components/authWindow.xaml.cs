using PR4.AllPages;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

    public partial class authWindow : Window
    { 
        public authWindow()
        {
            InitializeComponent();

        }
        database db = new database();
        int invalidPassword = 0;
        string createcapcha = "";

        private void auth_Click(object sender, RoutedEventArgs e)
        {
            string login = inputLogin.Text;
            string password = inputPass.Password;
            string capcha = inputCapcha.Text;


            if (CheckUser(login, password) && capcha == createcapcha)
            {
                var usersql = db.users.FirstOrDefault(x => x.login == login);
                string role = usersql.role.name.ToString();

                MainWindow main = new MainWindow();
                main.userClass.id = usersql.id;
                main.userClass.login = usersql.login;
                main.userClass.id_role = usersql.id_role;
                main.userClass.role = role;
                main.Show();
                Close();
            }
            else if (capcha != createcapcha)
            {
                MessageBox.Show("Пройдите проверку!");
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
                    invalidPassword = 0;
                }
            }
        }

        public bool CheckUser(string login, string password)
        {


            var user = db.users.FirstOrDefault(e => e.login == login);

            if (user == null)
            {
                MessageBox.Show("Такой пользователь не найден");
                return false;
            }

            if (user.password != password | user.login != login)
            {
                MessageBox.Show("Неправильный логин или пароль");
                return false;
            }

            return true;

        }


        private string createCAPCHA()
        {
            Random rnd = new Random();
            string capchaText = "";
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";

            for (int i = 0; i < 6; i++)
            {
                capchaText += ALF[rnd.Next(ALF.Length)];
            }
            return capchaText;




        }



    }
}
