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
using WpfApp4.Person;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для ChousePerson.xaml
    /// </summary>
    public partial class ChousePerson : Window
    {
        public ChousePerson()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ManButton_Click(object sender, RoutedEventArgs e)
        {
            ManWindow manWindow = new ManWindow();
            manWindow.Show();
            this.Close();
        }

        private void WomanButton_Click(object sender, RoutedEventArgs e)
        {
            WomanWindow womanWindow = new WomanWindow();
            womanWindow.Show();
            this.Close();
        }
    }
}
