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
using WpfApp4.PersonMan;

namespace WpfApp4.Person
{
    /// <summary>
    /// Логика взаимодействия для StoryManDay2_AtakaOglushennogo.xaml
    /// </summary>
    public partial class StoryManDay2_AtakaOglushennogo : Window
    {
        public StoryManDay2_AtakaOglushennogo()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Nabludenie storyManDay2Nabludenie = new StoryManDay2Nabludenie();
            storyManDay2Nabludenie.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Ataka_Ranenogo storyManDay2Ataka_Ranenogo = new StoryManDay2Ataka_Ranenogo();
            storyManDay2Ataka_Ranenogo.Show();
            this.Close();
        }
    }
}
