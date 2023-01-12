using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TextileStore2.Models;
using TextileStore2.Models.Entities;
using TextileStore2.View.Windows.Admin;

namespace TextileStore.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public ObservableCollection<ProductModel> productModels = new ObservableCollection<ProductModel>();
        public int Count { get; set; }
        public AdminWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Icon = new BitmapImage(new Uri("pack://application:,,,/bin/Debug/Images/icon.ico"));
            imgLogotype.Source = new BitmapImage(new Uri("pack://application:,,,/bin/Debug/Images/logo.png"));
            tbFullName.Text = tbFullName.Text = UserValidator.User.UserSurname + " " + UserValidator.User.UserName; ;

            List<string> listManufacter = new List<string>();
            using (TradeEntities tradeEntities = new TradeEntities())
            {
                foreach (var p in tradeEntities.ProductListForManagerAndClient)
                {
                    productModels.Add(ProductModel.ProductFromDB(p));
                    Count++;
                }
                lvProductList.ItemsSource = productModels.ToList();

                listManufacter.Add("Все производители");
                foreach (var m in tradeEntities.ProductManufacter)
                {
                    listManufacter.Add(m.ManufacterValue);
                }
                cbFilter.ItemsSource = listManufacter;
                tbCount.Text = $"Найдено: {Count}/{Count}";
            };
        }


        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            new AdminAddProductWindow().Show();
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            new AuthorizationWindow().Show();
            Close();
        }

        private void lvProductList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = lvProductList.SelectedItem;
            foreach (var product in productModels)
            {
                if (item == product)
                {
                    AdminEditProductWindow.Name = product.ProductName;
                    AdminEditProductWindow.Description = product.ProductDescription;
                    AdminEditProductWindow.Cost = Convert.ToDecimal(product.ProductCost);
                    AdminEditProductWindow.Manufacter = product.ProductManufacturer;
                    AdminEditProductWindow.Status = product.ProductStatus;
                    AdminEditProductWindow.Articul = product.ProductArticul;
                    AdminEditProductWindow.Category = product.ProductCategory;
                    AdminEditProductWindow.Discount = product.ProductDiscount;
                    AdminEditProductWindow.MaxDiscount = product.ProductMaxDiscount;
                    AdminEditProductWindow.Provider = product.ProductProvider;
                    AdminEditProductWindow.Unit = product.ProductUnit;
                    AdminEditProductWindow.QuantityInStock = product.ProductQuantityInStock;
                    AdminEditProductWindow.Image = product.ImagePath;
                }
            }
            new AdminEditProductWindow().Show();
        }
        private void cbOrderBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbFilter.SelectedIndex == 0 || cbFilter.SelectedIndex == -1)
            {
                if (cbOrderBy.SelectedIndex == 0)
                {
                    lvProductList.ItemsSource = productModels.OrderByDescending(c => Convert.ToDouble(c.ProductCost)).ToList();
                }
                else if (cbOrderBy.SelectedIndex == 1)
                {
                    lvProductList.ItemsSource = productModels.OrderBy(c => Convert.ToDouble(c.ProductCost)).ToList();
                }
                else
                {
                    lvProductList.ItemsSource = productModels.ToList();
                }
            }
            else
            {
                if (cbOrderBy.SelectedIndex == 0)
                {
                    lvProductList.ItemsSource =
                        productModels.Where(m =>
                        m.ProductManufacturer == cbFilter.SelectedItem.ToString()).OrderByDescending(c =>
                        Convert.ToDouble(c.ProductCost)).ToList();
                }
                else if (cbOrderBy.SelectedIndex == 1)
                {
                    lvProductList.ItemsSource = productModels.Where(m =>
                        m.ProductManufacturer == cbFilter.SelectedItem.ToString()).OrderBy(c =>
                        Convert.ToDouble(c.ProductCost)).ToList();
                }
                else
                {
                    lvProductList.ItemsSource = productModels.Where(m =>
                    m.ProductManufacturer == cbFilter.SelectedItem.ToString()).ToList();
                }
            }
        }

        private void tbFind_TextChanged(object sender, TextChangedEventArgs e)
        {
            int count = 0;
            productModels.Clear();
            using (TradeEntities tradeEntities = new TradeEntities())
            {
                foreach (var p in tradeEntities.ProductListForManagerAndClient)
                {
                    if (p.ProductDescription.Contains(tbFind.Text) || p.ProductName.Contains(tbFind.Text))
                    {
                        productModels.Add(ProductModel.ProductFromDB(p));
                        count++;
                    }

                }
                lvProductList.ItemsSource = productModels.ToList();
                tbCount.Text = $"Найдено: {count}/{Count}";
            }

        }

    }
}
