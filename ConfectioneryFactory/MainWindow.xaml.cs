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
using LibraryFactory;

namespace ConfectioneryFactory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            
            //ProductCalculator productCalculator = new ProductCalculator();
            //productCalculator.CalculateMaxCandyProduction();
            //TextB.Text = productCalculator.CalculateMaxCandyProduction().ToString();
            
        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            FactoryDBEntities factoryDBEntities = new FactoryDBEntities();
            try
            {
                var loginfo = factoryDBEntities.Users.Where(p => p.Login == LoginB.Text && p.Pass == PassB.Password).Single();
                Factory factory = new Factory(loginfo);
                factory.CurrentUser = loginfo;
                factory.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
    }
}
