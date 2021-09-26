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

namespace WpfApp4.PersonMan.Day3
{
    /// <summary>
    /// Логика взаимодействия для StoryManDay3Pesok_v_glaza.xaml
    /// </summary>
    public partial class StoryManDay3Pesok_v_glaza : Window
    {
        public StoryManDay3Pesok_v_glaza()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3SxvatitMech storyManDay3SxvatitMech = new StoryManDay3SxvatitMech();
            storyManDay3SxvatitMech.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3PoprobovatAtakovat storyManDay3PoprobovatAtakovat = new StoryManDay3PoprobovatAtakovat();
            storyManDay3PoprobovatAtakovat.Show();
            this.Close();
        }
    }
}
