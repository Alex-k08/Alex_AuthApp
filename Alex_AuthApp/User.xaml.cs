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
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Page
    {
        private Users user;
        public User(Users user)
        {
            this.user = user;
            InitializeComponent();
            Username.Content = user.Login;
            Password.Content = user.Password;
            Type.Content = $"Тип: {user.userType.name}";
        }
    }
}
