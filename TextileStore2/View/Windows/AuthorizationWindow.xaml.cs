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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            Icon = new BitmapImage(new Uri("pack://application:,,,/bin/Debug/Images/icon.ico"));
            imgLogotype.Source = new BitmapImage(new Uri("pack://application:,,,/bin/Debug/Images/logo.png"));
            mainFrame.Visibility = Visibility.Hidden;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

       
        private void btnViewProductList_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Visibility = Visibility.Visible;
            mainStackPanel.Visibility = Visibility.Hidden;
            btnSignIn.Visibility = Visibility.Hidden;
            mainFrame.Navigate(new ViewProductListPage());
        }

        private void btnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Visibility = Visibility.Hidden;
            mainStackPanel.Visibility = Visibility.Visible;
            btnSignIn.Visibility = Visibility.Visible;
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (UserValidator.ValidateUser(tbLogin.Text, tbPassword.Text))
                {
                    if (UserValidator.ValidateRole() == 1)
                    {
                        new AdminWindow().Show();
                        Close();
                    }
                    else if (UserValidator.ValidateRole() == 2)
                    {
                        new ManagerWindow().Show();
                        Close();
                    }
                    else if (UserValidator.ValidateRole() == 3)
                    {
                        new ClientWindow().Show();
                        Close();
                    }
                    else throw new Exception("Неизвестная роль");
                }
                else
                {
                    throw new Exception("Неверный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
