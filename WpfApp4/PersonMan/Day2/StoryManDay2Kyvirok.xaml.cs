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
    /// Логика взаимодействия для StoryManDay2Kyvirok.xaml
    /// </summary>
    public partial class StoryManDay2Kyvirok : Window
    {
        public StoryManDay2Kyvirok()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Yklonenie_Kolushii_Ydar storyManDay2Yklonenie_Kolushii_Ydar = new StoryManDay2Yklonenie_Kolushii_Ydar();
            storyManDay2Yklonenie_Kolushii_Ydar.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Prervat_ataky storyManDay2Prervat_Ataky = new StoryManDay2Prervat_ataky();
            storyManDay2Prervat_Ataky.Show();
            this.Close();
        }
    }
}
