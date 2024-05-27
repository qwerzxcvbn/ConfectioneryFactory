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
using LibraryFactory;

namespace ConfectioneryFactory
{
    /// <summary>
    /// Логика взаимодействия для ProductCalcul.xaml
    /// </summary>
    public partial class ProductCalcul : Window
    {
        private ProductCalculator productCalculator;
        public ProductCalcul()
        {
            InitializeComponent();
            FactoryDBEntities factoryDBEntities = new FactoryDBEntities();
            var stockItem = factoryDBEntities.Stock.FirstOrDefault(); 
            if (stockItem != null)
            {
                manka.Text = stockItem.Munka.ToString();
                oil.Text = stockItem.Butter.ToString();
                sugar.Text = stockItem.Sugar.ToString();
                cocoa.Text = stockItem.Cocoa.ToString();
                water.Text = stockItem.Water.ToString();
            }
            productCalculator = new ProductCalculator();

        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            double mankaAvailable, butterAvailable, sugarAvailable, cocoaPowderAvailable, waterAvailable;

            if (!double.TryParse(manka.Text, out mankaAvailable) ||
                !double.TryParse(oil.Text, out butterAvailable) ||
                !double.TryParse(sugar.Text, out sugarAvailable) ||
                !double.TryParse(cocoa.Text, out cocoaPowderAvailable) ||
                !double.TryParse(water.Text, out waterAvailable))
            {
                result.Text = "Пожалуйста, введите корректные числовые значения.";
                return;
            }

            int maxCandyProduction = productCalculator.CalculateMaxCandyProduction(mankaAvailable, butterAvailable, sugarAvailable, cocoaPowderAvailable, waterAvailable);

            result.Text = maxCandyProduction.ToString(); // Результат в упаковках (6 шт)
        }
    }
}
