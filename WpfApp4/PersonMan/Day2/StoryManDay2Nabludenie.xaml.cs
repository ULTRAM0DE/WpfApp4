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
using WpfApp4.PersonMan.Day2;

namespace WpfApp4.PersonMan
{
    /// <summary>
    /// Логика взаимодействия для StoryManDay2Nabludenie.xaml
    /// </summary>
    public partial class StoryManDay2Nabludenie : Window
    {
        public StoryManDay2Nabludenie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Kyvirok storyManDay2Kyvirok = new StoryManDay2Kyvirok();
            storyManDay2Kyvirok.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryMan2Block_Klinka storyMan2Block_Klinka = new StoryMan2Block_Klinka();
            storyMan2Block_Klinka.Show();
            this.Close();

        }
    }
}
