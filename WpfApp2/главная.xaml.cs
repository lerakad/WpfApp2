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
    /// Логика взаимодействия для главная.xaml
    /// </summary>
    public partial class главная : Window
    {
        public главная()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            главная главная = new главная();
            главная.Show();
            this.Close();
        }

        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            материал материал = new материал();
            материал.Show();
            this.Close();
        }
    }
}
