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
    /// Логика взаимодействия для StoryManDay3AtakaOtRychanie.xaml
    /// </summary>
    public partial class StoryManDay3AtakaOtRychanie : Window
    {
        public StoryManDay3AtakaOtRychanie()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3BlockRanenii storyManDay3 = new StoryManDay3BlockRanenii();
            storyManDay3.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3Yklonenie_Ranenie day3Yklonenie_Ranenie = new StoryManDay3Yklonenie_Ranenie();
            day3Yklonenie_Ranenie.Show();
            this.Close();
        }
    }
}
