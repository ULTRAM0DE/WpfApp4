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
    /// Логика взаимодействия для StoryMan2Piruet.xaml
    /// </summary>
    public partial class StoryMan2Piruet : Window
    {
        public StoryMan2Piruet()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2 storyManDay2 = new StoryManDay2();
            storyManDay2.Show();
            this.Close();
        }
    }
}
