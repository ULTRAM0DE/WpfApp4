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
    /// Логика взаимодействия для StoryManDay3_Fight.xaml
    /// </summary>
    public partial class StoryManDay3_Fight : Window
    {
        public StoryManDay3_Fight()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3AtakaOtRychanie storyManDay3AtakaOtRychanie = new StoryManDay3AtakaOtRychanie();
            storyManDay3AtakaOtRychanie.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay3YklonenieOtRychanie storyManDay3YklonenieOtRychanie = new StoryManDay3YklonenieOtRychanie();
            storyManDay3YklonenieOtRychanie.Show();
            this.Close();
        }
    }
}
