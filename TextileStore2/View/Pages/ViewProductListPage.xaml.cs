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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TextileStore2.Models;
using TextileStore2.Models.Entities;

namespace TextileStore2.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewProductList.xaml
    /// </summary>
    public partial class ViewProductListPage : Page
    {
        public ObservableCollection<ProductModel> productModels = new ObservableCollection<ProductModel>();
        public ViewProductListPage()
        {
            InitializeComponent();
            List<string> listManufacter = new List<string>();
            using (TradeEntities tradeEntities = new TradeEntities())
            {
                foreach (var p in tradeEntities.ProductListForManagerAndClient)
                {
                    productModels.Add(ProductModel.ProductFromDB(p));
                }
                lvProductList.ItemsSource = productModels.ToList();

                listManufacter.Add("Все производители");
                foreach (var m in tradeEntities.ProductManufacter)
                {
                    listManufacter.Add(m.ManufacterValue);
                }
                cbFilter.ItemsSource = listManufacter;
            };
           
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
                    lvProductList.ItemsSource = productModels.ToList();
                }
            }
        }

        private void tbFind_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
