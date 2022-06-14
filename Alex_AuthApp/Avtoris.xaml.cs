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

namespace Alex_AuthApp
{
    /// <summary>
    /// Логика взаимодействия для Avtoris.xaml
    /// </summary>
    public partial class Avtoris : Page
    {
        public Avtoris()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Pass.Text == Povtpass.Text && Pass.Text != "")
            {

                MessageBox.Show("Вы авторизовались");


            }
            else
            {
                MessageBox.Show("Пароль введён неправильно");
            }
            if (Pass.Text == "")
            {
                MessageBox.Show("Вы не ввели пароль");
            }
            var db = new alex_kEntities1();
            var user = new Users();
            user.Login = Login.Text;
            user.Password = Pass.Text;
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}
