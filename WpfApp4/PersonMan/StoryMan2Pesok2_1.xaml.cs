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
    /// Логика взаимодействия для StoryMan2Pesok2_1.xaml
    /// </summary>
    public partial class StoryMan2Pesok2_1 : Window
    {
        public StoryMan2Pesok2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryMan2Pesok3_2 storyMan2Pesok3_2 = new StoryMan2Pesok3_2();
            storyMan2Pesok3_2.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoreMan2Pesok3_1 storyMan2Pesok3_1 = new StoreMan2Pesok3_1();
            storyMan2Pesok3_1.Show();
            this.Close();
        }
    }
}
