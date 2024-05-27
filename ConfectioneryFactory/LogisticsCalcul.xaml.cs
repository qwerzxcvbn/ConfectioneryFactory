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
    /// Логика взаимодействия для LogisticsCalcul.xaml
    /// </summary>
    public partial class LogisticsCalcul : Window
    {
        public LogisticsCalcul()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(distance.Text, out double distanceValue) && double.TryParse(pricekm.Text, out double priceKmValue))
            {
                LogisticsCalculator calculator = new LogisticsCalculator();
                double resultValue = calculator.CalculateLogistics(distanceValue, priceKmValue);
                result.Text = resultValue.ToString();
            }
            else
            {
                result.Text = "Ошибка ввода данных";
            }
        }
    }
}
