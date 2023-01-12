using Microsoft.Win32;
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
using TextileStore2.Models.Entities;

namespace TextileStore2.View.Windows.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminEditProductWindow.xaml
    /// </summary>
    public partial class AdminEditProductWindow : Window
    {
        public static string ImagePath { get; set; }
        public static string Image { get; set; }
        public static string Description { get; set; }
        public static string Name { get; set; }
        public static string Articul { get; set; }
        public static string Category { get; set; }
        public static string Provider { get; set; }
        public static string Manufacter { get; set; }
        public static string Unit { get; set; }
        public static string Status { get; set; }
        public static decimal Cost { get; set; }
        public static byte? Discount { get; set; }
        public static int? MaxDiscount { get; set; }
        public static int? QuantityInStock { get; set; }
        public AdminEditProductWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Icon = new BitmapImage(new Uri("pack://application:,,,/bin/Debug/Images/icon.ico"));

            List<string> listCategory = new List<string>();
            List<string> listProvider = new List<string>();
            List<string> listManufacter = new List<string>();
            List<string> listUnit = new List<string>();
            List<string> listStatus = new List<string>();
            List<string> listArticul = new List<string>();
            using (TradeEntities tradeEntities = new TradeEntities())
            {
                foreach (var c in tradeEntities.ProductCategory)
                {
                    listCategory.Add(c.CategoryValue);
                }
                cbCategory.ItemsSource = listCategory;

                foreach (var p in tradeEntities.ProductProvider)
                {
                    listProvider.Add(p.ProviderValue);
                }
                cbProvider.ItemsSource = listProvider;

                foreach (var m in tradeEntities.ProductManufacter)
                {
                    listManufacter.Add(m.ManufacterValue);
                }
                cbManufacter.ItemsSource = listManufacter;

                foreach (var u in tradeEntities.ProductUnit)
                {
                    listUnit.Add(u.UnitValue);
                }
                cbUnit.ItemsSource = listUnit;

                foreach (var s in tradeEntities.ProductStatus)
                {
                    listStatus.Add(s.StatusValue);
                }
                cbStatus.ItemsSource = listStatus;
            };
            tbDescription.Text = Description;
            tbName.Text = Name;
            cbManufacter.SelectedItem = Manufacter;
            cbStatus.SelectedItem = Status;
            tbArticul.Text = Articul;
            tbCost.Text = Cost.ToString();
            tbDiscount.Text = Discount.ToString();
            tbMaxDiscount.Text = MaxDiscount.ToString();
            tbQuantityInStock.Text = QuantityInStock.ToString();
            cbProvider.SelectedItem = Provider;
            cbUnit.SelectedItem = Unit;
            cbCategory.SelectedItem = Category;
            ImagePath = Image;
        }
        private void btnEditNewProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (InputDataValidator.ValidateValueAddNewProduct(tbArticul.Text, tbName.Text,
                   tbDescription.Text, cbCategory.Text, cbManufacter.Text,
                   Convert.ToDouble(tbCost.Text), Convert.ToDouble(tbDiscount.Text),
                   Convert.ToDouble(tbMaxDiscount.Text), Convert.ToInt32(tbQuantityInStock.Text),
                   cbStatus.Text, cbUnit.Text, cbProvider.Text))
                {
                    using (TradeEntities context = new TradeEntities())
                    {
                        context.EditProduct(tbArticul.Text, tbName.Text,
                           tbDescription.Text, cbCategory.Text, ImagePath, cbManufacter.Text,
                           Convert.ToDecimal(tbCost.Text), Convert.ToByte(tbDiscount.Text),
                           Convert.ToInt32(tbMaxDiscount.Text), Convert.ToInt32(tbQuantityInStock.Text),
                           cbStatus.Text, cbUnit.Text, cbProvider.Text, false);
                        context.SaveChanges();
                        MessageBox.Show("Запись обновлена");
                    }
                }
                else
                {
                    throw new Exception("Поля не могут быть пустыми");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpeg;*.jpg;*.JPG)|*jpeg;*.jpg;*.JPG)";
            openFileDialog.ShowDialog();

            ImagePath = openFileDialog.SafeFileName;
            if (ImagePath == "")
                ImagePath = null;

            string destFile =
                System.IO.Path.Combine("Images/", ImagePath);
            System.IO.File.Copy(openFileDialog.FileName, destFile, true);
           
        }

        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            using (TradeEntities context = new TradeEntities())
            {
                var product = context.Product.FirstOrDefault(p => p.ProductArticleNumber == tbArticul.Text);
                context.Product.Remove(product);
                context.SaveChanges();
                MessageBox.Show("Запись удалена");
            }
        }
    }
}
