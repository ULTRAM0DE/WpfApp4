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

namespace WpfApp4.Person
{
    /// <summary>
    /// Логика взаимодействия для WomanWindow.xaml
    /// </summary>
    public partial class WomanWindow : Window
    {
        public WomanWindow()
        {
            InitializeComponent();
        }

        private void Story2button_Click(object sender, RoutedEventArgs e)
        {
            WomanStory womanStory = new WomanStory();
            womanStory.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ChousePerson chouse = new ChousePerson();
            chouse.Show();
            this.Close();
        }
    }
}
