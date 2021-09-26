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
    /// Логика взаимодействия для StoryManDay3Yklonenie_Noga.xaml
    /// </summary>
    public partial class StoryManDay3Yklonenie_Noga : Window
    {
        public StoryManDay3Yklonenie_Noga()
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
