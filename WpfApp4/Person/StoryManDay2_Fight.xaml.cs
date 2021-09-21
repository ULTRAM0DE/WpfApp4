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
    /// Логика взаимодействия для StoryManDay2_Fight.xaml
    /// </summary>
    public partial class StoryManDay2_Fight : Window
    {
        public StoryManDay2_Fight()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Napadenie storyManDay2Napadenie = new StoryManDay2Napadenie();
            storyManDay2Napadenie.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Yklonenie storyManDay2Yklonenie = new StoryManDay2Yklonenie();
            storyManDay2Yklonenie.Show();
            this.Close();
        }
    }
}
