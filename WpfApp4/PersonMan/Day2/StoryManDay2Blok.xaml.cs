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

namespace WpfApp4.PersonMan.Day2
{
    /// <summary>
    /// Логика взаимодействия для StoryManDay2Blok.xaml
    /// </summary>
    public partial class StoryManDay2Blok : Window
    {
        public StoryManDay2Blok()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Blok_Vihrevaya_Ataka manDay2Blok_Vihrevaya_Ataka = new StoryManDay2Blok_Vihrevaya_Ataka();
            manDay2Blok_Vihrevaya_Ataka.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Yklonenie_Vihrevaya_Ataka storyManDay2Yklonenie_Vihrevaya_Ataka = new StoryManDay2Yklonenie_Vihrevaya_Ataka();
            storyManDay2Yklonenie_Vihrevaya_Ataka.Show();
            this.Close();
        }
    }
}
