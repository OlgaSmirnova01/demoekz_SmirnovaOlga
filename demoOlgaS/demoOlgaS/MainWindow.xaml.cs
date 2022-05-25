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

namespace demoOlgaS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Поставщики_Click(object sender, RoutedEventArgs e)
        {
            Window postwin = new Postavshik();
            postwin.Show();
            Close();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Window klwin = new Klient();
            klwin.Show();
            Close();
      
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
