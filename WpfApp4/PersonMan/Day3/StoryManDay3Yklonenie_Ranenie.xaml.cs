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
    /// Логика взаимодействия для StoryManDay3Yklonenie_Ranenie.xaml
    /// </summary>
    public partial class StoryManDay3Yklonenie_Ranenie : Window
    {
        public StoryManDay3Yklonenie_Ranenie()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3Pesok_v_glaza storyManDay3Pesok_V_Glaza = new StoryManDay3Pesok_v_glaza();
            storyManDay3Pesok_V_Glaza.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3Ataka_nogi storyManDay3Ataka_Nogi = new StoryManDay3Ataka_nogi();
            storyManDay3Ataka_Nogi.Show();
            this.Close();
        }
    }
}
