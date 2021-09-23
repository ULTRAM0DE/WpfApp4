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
using WpfApp4.PersonMan.Day3;

namespace WpfApp4.PersonMan.Day2
{
    /// <summary>
    /// Логика взаимодействия для StoryManDay2Blok_Vihrevaya_Ataka.xaml
    /// </summary>
    public partial class StoryManDay2Blok_Vihrevaya_Ataka : Window
    {
        public StoryManDay2Blok_Vihrevaya_Ataka()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3 storyManDay3 = new StoryManDay3();
            storyManDay3.Show();
            this.Close();
        }
    }
}
