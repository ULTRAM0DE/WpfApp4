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
    /// Логика взаимодействия для StoryMan2Pesok.xaml
    /// </summary>
    public partial class StoryMan2Pesok : Window
    {
        public StoryMan2Pesok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryMan2_2Pesok storyMan2_2Pesok = new StoryMan2_2Pesok();
            storyMan2_2Pesok.Show();
            this.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryMan2Pesok2_1 storyMan2Pesok2_1 = new StoryMan2Pesok2_1();
            storyMan2Pesok2_1.Show();
            this.Close();
        }
    }
}
