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
using TextileStore2.Core;
using TextileStore2.Models.Entities;

namespace TextileStore2.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminEditProductPage.xaml
    /// </summary>
    public partial class AdminEditProductPage : Page
    {
        public AdminEditProductPage()
        {
            InitializeComponent();
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

                foreach (var a in tradeEntities.Product)
                {
                    listArticul.Add(a.ProductArticleNumber);
                }
                cbArticul.ItemsSource = listArticul;
            };
        }

        private void btnEditNewProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (InputDataValidator.ValidateValueAddNewProduct(cbArticul.Text, tbName.Text,
                   tbDescription.Text, cbCategory.Text, cbManufacter.Text,
                   Convert.ToDouble(tbCost.Text), Convert.ToDouble(tbDiscount.Text),
                   Convert.ToDouble(tbMaxDiscount.Text), Convert.ToInt32(tbQuantityInStock.Text),
                   cbStatus.Text, cbUnit.Text, cbProvider.Text))
                {
                    using (TradeEntities context = new TradeEntities())
                    {
                        context.EditProduct(cbArticul.Text ,tbName.Text,
                           tbDescription.Text, cbCategory.Text, cbPhoto.Text, cbManufacter.Text,
                           Convert.ToDecimal(tbCost.Text), Convert.ToByte(tbDiscount.Text),
                           Convert.ToInt32(tbMaxDiscount.Text), Convert.ToInt32(tbQuantityInStock.Text),
                           cbStatus.Text, cbUnit.Text, cbProvider.Text, false);
                        context.SaveChanges();
                        MessageBox.Show("Запись обновлена");
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
    }
}
