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
    /// Логика взаимодействия для StoryManDay2.xaml
    /// </summary>
    public partial class StoryManDay2 : Window
    {
        public StoryManDay2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2_Fight storyManDay2_Fight = new StoryManDay2_Fight();
            storyManDay2_Fight.Show();
            this.Close();
        }
    }
}
