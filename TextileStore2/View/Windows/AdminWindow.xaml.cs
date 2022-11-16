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
using TextileStore2.View.Pages.Admin;

namespace TextileStore.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            imgLogotype.Source = new BitmapImage(new Uri("pack://application:,,,/Assets/Images/logo.png"));
            Icon = new BitmapImage(new Uri("pack://application:,,,/Assets/Images/icon.ico"));
            tbFullName.Text = tbFullName.Text = UserValidator.User.UserSurname + " " + UserValidator.User.UserName; ;
        }

        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AdminEditProductPage());
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AdminAddProductPage());
        }

        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AdminDeleteProductPage());
        }
        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            new AuthorizationWindow().Show();
            Close();
        }
    }
}
