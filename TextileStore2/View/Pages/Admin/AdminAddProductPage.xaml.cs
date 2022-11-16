using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using TextileStore2.Core;
using TextileStore2.Models;
using TextileStore2.Models.Entities;

namespace TextileStore2.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminAddProductPage.xaml
    /// </summary>
    public partial class AdminAddProductPage : Page
    {
        public string ImagePath { get; set; }
        public AdminAddProductPage()
        {
            InitializeComponent();
            List<string> listCategory = new List<string>();
            List<string> listProvider = new List<string>();
            List<string> listManufacter = new List<string>();
            List<string> listUnit = new List<string>();
            List<string> listStatus = new List<string>();
            using (TradeEntities tradeEntities = new TradeEntities())
            {
                foreach(var c in tradeEntities.ProductCategory)
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
        }

        private void btnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (InputDataValidator.ValidateValueAddNewProduct(tbArticul.Text, tbName.Text,
                   tbDescription.Text, cbCategory.Text, cbManufacter.Text,
                   Convert.ToDouble(tbCost.Text), Convert.ToDouble(tbDiscount.Text),
                   Convert.ToDouble(tbMaxDiscount.Text), Convert.ToInt32(tbQuantityInStock.Text),
                   cbStatus.Text, cbUnit.Text, cbProvider.Text))
                {
                    using(TradeEntities context = new TradeEntities())
                    {
                        var product = context.Product.FirstOrDefault(p =>
                        p.ProductArticleNumber == tbArticul.Text);
                        if(product != null)
                        {
                            MessageBox.Show("Товар с таким артикулом уже существует");
                        }
                        else
                        {
                            context.AddProduct(tbArticul.Text, tbName.Text,
                           tbDescription.Text, cbCategory.Text, ImagePath, cbManufacter.Text,
                           Convert.ToDecimal(tbCost.Text), Convert.ToByte(tbDiscount.Text),
                           Convert.ToInt32(tbMaxDiscount.Text), Convert.ToInt32(tbQuantityInStock.Text),
                           cbStatus.Text, cbUnit.Text, cbProvider.Text, false);
                            context.SaveChanges();
                            MessageBox.Show("Запись добавлена");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Поля не могут быть пустыми");
                }
            }
            catch(Exception ex)
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
    }
}
