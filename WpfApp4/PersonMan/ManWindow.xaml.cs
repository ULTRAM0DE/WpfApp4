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
using System.Drawing;
using System.Drawing.Text;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для ManWindow.xaml
    /// </summary>
    public partial class ManWindow : Window
    {
        
        public ManWindow()
        {
            InitializeComponent();
            
        }

       
        

        private void Story1button_Click(object sender, RoutedEventArgs e)
        {
            StoryMan storyMan = new StoryMan();
            storyMan.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ChousePerson chousePerson = new ChousePerson();
            chousePerson.Show();
            this.Close();
        }
    }
}
