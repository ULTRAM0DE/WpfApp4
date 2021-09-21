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
    /// Логика взаимодействия для StoryMan.xaml
    /// </summary>
    public partial class StoryMan : Window
    {
        public StoryMan()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryMan2Pesok storyMan2Pesok = new StoryMan2Pesok();
            storyMan2Pesok.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryMan2Piruet storyMan2Piruet = new StoryMan2Piruet();
            storyMan2Piruet.Show();
            this.Close();
        }
    }
}
