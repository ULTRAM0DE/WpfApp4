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

namespace WpfApp4.Person
{
    /// <summary>
    /// Логика взаимодействия для StoreMan2Pesok3_1.xaml
    /// </summary>
    public partial class StoreMan2Pesok3_1 : Window
    {
        public StoreMan2Pesok3_1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2 storyManDay2 = new StoryManDay2();
            storyManDay2.Show();
            this.Close();
        }
    }
}
