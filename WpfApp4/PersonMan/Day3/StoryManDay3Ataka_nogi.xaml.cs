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
    /// Логика взаимодействия для StoryManDay3Ataka_nogi.xaml
    /// </summary>
    public partial class StoryManDay3Ataka_nogi : Window
    {
        public StoryManDay3Ataka_nogi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3SxvatitMech storyManDay3SxvatitMech = new StoryManDay3SxvatitMech();
            storyManDay3SxvatitMech.Show();
            this.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3Yklonenie_Noga storyManDay3Yklonenie_Noga = new StoryManDay3Yklonenie_Noga();
            storyManDay3Yklonenie_Noga.Show();
            this.Close();
        }
    }
}
