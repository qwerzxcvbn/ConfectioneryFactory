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


namespace ConfectioneryFactory
{
    /// <summary>
    /// Логика взаимодействия для Factory.xaml
    /// </summary>
    public partial class Factory : Window
    {
        
        public Users CurrentUser { get; set; }

        public Factory(Users currentUser) // Добавляем параметр в конструктор
        {
            
            InitializeComponent();                  
            CurrentUser = currentUser; // Устанавливаем свойство CurrentUser при инициализации
            if (CurrentUser != null)
            {
                Depar.Text = $"Должность: {CurrentUser.Department}";
                fioB.Text = $"ФИО: {CurrentUser.FIO}";
            }
            Loaded += Grid;
            
        }
        private void Grid(object sender, RoutedEventArgs e)
        {
            FactoryDBEntities factoryDBEntities = new FactoryDBEntities();
            StockGrid.ItemsSource = factoryDBEntities.Stock.ToList(); // Устанавливаем источник данных после загрузки окна
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            ProductCalcul productCalcul = new ProductCalcul();
            productCalcul.Show();
            
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            LogisticsCalcul logisticsCalcul = new LogisticsCalcul();
            logisticsCalcul.Show();
        }
    }
}
