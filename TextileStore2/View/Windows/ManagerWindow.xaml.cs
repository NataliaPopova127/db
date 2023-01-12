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
using TextileStore2.Core;
using TextileStore2.View.Pages;

namespace TextileStore.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Icon = new BitmapImage(new Uri("pack://application:,,,/bin/Debug/Images/icon.ico"));
            imgLogotype.Source = new BitmapImage(new Uri("pack://application:,,,/bin/Debug/Images/logo.png"));
            tbFullName.Text = UserValidator.User.UserSurname + " " + UserValidator.User.UserName;
        }

        private void btnProductList_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ViewProductListPage());
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            new AuthorizationWindow().Show();
            Close();
        }
    }
}
