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
using TextileStore2.Models.Entities;

namespace TextileStore2.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminDeleteProductPage.xaml
    /// </summary>
    public partial class AdminDeleteProductPage : Page
    {
        public AdminDeleteProductPage()
        {
            InitializeComponent();
            List<string> listArticul = new List<string>();
            using (TradeEntities tradeEntities = new TradeEntities())
            {
                foreach (var a in tradeEntities.Product)
                {
                    listArticul.Add(a.ProductArticleNumber);
                }
                cbArticul.ItemsSource = listArticul;
            }
            
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(cbArticul.Text != "")
            {
                using (TradeEntities context = new TradeEntities())
                {
                    var product = context.Product.FirstOrDefault(p => p.ProductArticleNumber == cbArticul.Text);
                    context.Product.Remove(product);
                    context.SaveChanges();
                    MessageBox.Show("Запись удалена");
                }
            }
            else
            {
                MessageBox.Show("Выберите артикул");
            }
        }
    }
}
