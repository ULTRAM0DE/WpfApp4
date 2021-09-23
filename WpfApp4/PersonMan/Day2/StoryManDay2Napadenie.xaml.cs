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
using WpfApp4.PersonMan.Day2;

namespace WpfApp4.Person
{
    /// <summary>
    /// Логика взаимодействия для StoryManDay2Napadenie.xaml
    /// </summary>
    public partial class StoryManDay2Napadenie : Window
    {
        public StoryManDay2Napadenie()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Ataka_VtoroyYdarAktoviana storyManDay2Ataka_VtoroyYdarAktoviana = new StoryManDay2Ataka_VtoroyYdarAktoviana();
            storyManDay2Ataka_VtoroyYdarAktoviana.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StoryManDay2Blok storyManDay2Blok = new StoryManDay2Blok();
            storyManDay2Blok.Show();
            this.Close();
        }
    }
}
