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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для материал.xaml
    /// </summary>
    public partial class материал : Window
    {
        public материал()
        {
            InitializeComponent();
            DGrid.ItemsSource = KostinaVDEntities1.GetContext().Table_Materiali.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            главная главная = new главная();
            главная.Show();
            this.Close();
        }

        private void DGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
