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
    /// Логика взаимодействия для Regest.xaml
    /// </summary>
    public partial class Regest : Page
    {
        public Regest()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = new alex_kEntities();
            var users = x.Users.Where((user) => user.Login == Login1.Text && user.Password == Password1.Password).ToList();
            if (users.Count > 0)
            {
                Console.WriteLine(users[0].userType.name);
                if (users[0].userType.name == "user")
                {
                    NavigationService.Navigate(new User(users[0]));
                }
                else
                {
                    NavigationService.Navigate(new Admin(users[0]));
                }
            }
            else
            {
                MessageBox.Show("user not found");
            }

        }
    }
}
